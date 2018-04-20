using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using System.IO;

namespace ImagesToTiffCoversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Title = "Select an image: ";
            fd.Filter = "Image files (*.jpg, *.jpeg, *.bmp, *.gif, *.png) | *.jpg; *.jpeg; *.bmp; *.gif; *.png";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string filename = fd.FileName.ToString();
                imageList.Items.Add(filename);
            }
        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblLoaded_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblResultPath_Click(object sender, EventArgs e)
        {

        }

        private void conversionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (imageList.Items.Count == 0)
            {
                MessageBox.Show("Nothing to remove.", "No items",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                imageList.Items.Clear();
            }
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            if (imageList.SelectedIndex >= 0)
            {
                imageList.Items.RemoveAt(imageList.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select an item to remove it.", "Nothing selected",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void ConvertToTiff(string[] fileNames, string tiffPath)
        {

            EncoderParameters encoderParams = new EncoderParameters(1);
            ImageCodecInfo tiffCodecInfo = ImageCodecInfo.GetImageEncoders()
                .First(ie => ie.MimeType == "image/tiff");


            System.Drawing.Image tiffImg = null;
            conn.Open();

            try
            {
                for (int i = 0; i < fileNames.Length; i++)
                {
                    if (i == 0)
                    {

                        // Initialize the first frame of multipage tiff.
                        tiffImg = System.Drawing.Image.FromFile(fileNames[i]);
                        encoderParams.Param[0] = new EncoderParameter(
                            System.Drawing.Imaging.Encoder.SaveFlag, (long)EncoderValue.MultiFrame);
                        tiffImg.Save(tiffPath, tiffCodecInfo, encoderParams);
                    }
                    else
                    {
                        // Add additional frames.
                        encoderParams.Param[0] = new EncoderParameter(
                            System.Drawing.Imaging.Encoder.SaveFlag, (long)EncoderValue.FrameDimensionPage);
                        using (System.Drawing.Image frame = System.Drawing.Image.FromFile(fileNames[i]))
                        {
                            tiffImg.SaveAdd(frame, encoderParams);
                        }
                    }
                    
                    string sqlcmd = "INSERT INTO tiffconvinfo (source_path,destination_path,conversion_datetime,db_username,computer_name,image_size_in_kb) VALUES (@source, @destination, @date, @user, @comp, @size)";
                    MySqlCommand cmd = new MySqlCommand(sqlcmd, conn);
                    cmd.Parameters.AddWithValue("@source", fileNames[i]); //path to every image to be converted
                    cmd.Parameters.AddWithValue("@destination", tiffPath); //destination tiff file path
                    cmd.Parameters.AddWithValue("@date", DateTime.Now); //current date and time of computer
                    cmd.Parameters.AddWithValue("@user", username); //current loged user
                    cmd.Parameters.AddWithValue("@comp", Environment.MachineName); // name of local computer

                    float sz = (float)new FileInfo(fileNames[i]).Length / (float)1024; //calculating image size in bytes for every image
                    cmd.Parameters.AddWithValue("@size", sz);
                   
                    cmd.ExecuteNonQuery();

                    if (i == fileNames.Length - 1)
                    {
                        // When we added the last frame,we flush the resources and close.
                        encoderParams.Param[0] = new EncoderParameter(
                            System.Drawing.Imaging.Encoder.SaveFlag, (long)EncoderValue.Flush);
                        tiffImg.SaveAdd(encoderParams);
                    }
                }
            }
            finally
            {
                if (tiffImg != null)
                {
                    tiffImg.Dispose();
                    tiffImg = null;
                }

            }

        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            if (imageList.Items.Count != 0)
            {
                SaveFileDialog sv = new SaveFileDialog();

                sv.Title = "Destination file selection:";
                sv.Filter = "tiff files (*.tiff)|*.tiff";

                int counter = 0;

                for (int i = 0; i < imageList.Items.Count; i++)
                {
                    counter++;
                }

                string[] images = new string[counter];

                for (int i = 0; i < imageList.Items.Count; i++)
                {
                    images[i] = imageList.Items[i].ToString();
                }

                if (sv.ShowDialog() == DialogResult.OK)
                {
                    ConvertToTiff(images, sv.FileName.ToString());
                    lblResult.Text = "Successfully converted " + counter.ToString() + " image(s) to file: ";
                    lblResultPath.Text = sv.FileName.ToString();

                }
            }
            else
            {
                MessageBox.Show("Load images to convert them.", "No images loaded",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conversionPanel.Visible = false;
            panelLogin.Visible = true;
            conn.Close();
        }
        
        public static string username;
        public static MySqlConnection conn;

        public void btnLogin_Click(object sender, EventArgs e)
        {
            

            string host = txtServer.Text;
            string user = txtUser.Text;
            username = user;
            string pass = txtPass.Text;

            string connectionString = "server=" + host + ";database=tiffconversiondb;uid=" + user + ";pwd=" + pass + ";";
            conn = new MySqlConnection(connectionString);

            try {
                conn.Open();
                txtPass.Text = "";
                conversionPanel.Visible = true;
                panelLogin.Visible = false;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed!");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is incorrect!");
                        break;

                }
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
