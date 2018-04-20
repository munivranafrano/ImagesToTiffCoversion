namespace ImagesToTiffCoversion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.conversionPanel = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRmv = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblResultPath = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblLoaded = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ListBox();
            this.conversionPanel.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // conversionPanel
            // 
            this.conversionPanel.Controls.Add(this.button1);
            this.conversionPanel.Controls.Add(this.btnSave);
            this.conversionPanel.Controls.Add(this.btnRmv);
            this.conversionPanel.Controls.Add(this.btnRemoveAll);
            this.conversionPanel.Controls.Add(this.btnLoad);
            this.conversionPanel.Controls.Add(this.lblResultPath);
            this.conversionPanel.Controls.Add(this.lblResult);
            this.conversionPanel.Controls.Add(this.lblLoaded);
            this.conversionPanel.Controls.Add(this.imageList);
            this.conversionPanel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionPanel.Location = new System.Drawing.Point(-1, -3);
            this.conversionPanel.Name = "conversionPanel";
            this.conversionPanel.Size = new System.Drawing.Size(412, 371);
            this.conversionPanel.TabIndex = 0;
            this.conversionPanel.Visible = false;
            this.conversionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.conversionPanel_Paint);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.txtUser);
            this.panelLogin.Controls.Add(this.txtServer);
            this.panelLogin.Controls.Add(this.lblPass);
            this.panelLogin.Controls.Add(this.lblUser);
            this.panelLogin.Controls.Add(this.lblServer);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(412, 368);
            this.panelLogin.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(139, 268);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 39);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(201, 210);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(201, 167);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 5;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(201, 127);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 4;
            this.txtServer.Text = "localhost";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(97, 213);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(97, 170);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(97, 130);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(134, 68);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(132, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "MySQL Login";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(18, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(13, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Convert to .tiff";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRmv
            // 
            this.btnRmv.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRmv.Location = new System.Drawing.Point(13, 116);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(145, 37);
            this.btnRmv.TabIndex = 6;
            this.btnRmv.Text = "Remove selected item";
            this.btnRmv.UseVisualStyleBackColor = false;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveAll.Location = new System.Drawing.Point(13, 159);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(145, 37);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "Remove all";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLoad.Location = new System.Drawing.Point(13, 39);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(145, 37);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load image(s)";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblResultPath
            // 
            this.lblResultPath.AutoSize = true;
            this.lblResultPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultPath.Location = new System.Drawing.Point(169, 313);
            this.lblResultPath.Name = "lblResultPath";
            this.lblResultPath.Size = new System.Drawing.Size(0, 15);
            this.lblResultPath.TabIndex = 3;
            this.lblResultPath.Click += new System.EventHandler(this.lblResultPath_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.Location = new System.Drawing.Point(169, 285);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblLoaded
            // 
            this.lblLoaded.AutoSize = true;
            this.lblLoaded.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLoaded.Location = new System.Drawing.Point(279, 21);
            this.lblLoaded.Name = "lblLoaded";
            this.lblLoaded.Size = new System.Drawing.Size(97, 15);
            this.lblLoaded.TabIndex = 1;
            this.lblLoaded.Text = "Loaded images:";
            this.lblLoaded.Click += new System.EventHandler(this.lblLoaded_Click);
            // 
            // imageList
            // 
            this.imageList.FormattingEnabled = true;
            this.imageList.ItemHeight = 14;
            this.imageList.Location = new System.Drawing.Point(172, 39);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(217, 228);
            this.imageList.TabIndex = 0;
            this.imageList.SelectedIndexChanged += new System.EventHandler(this.imageList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 365);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.conversionPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TiffConverter";
            this.conversionPanel.ResumeLayout(false);
            this.conversionPanel.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conversionPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblResultPath;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblLoaded;
        private System.Windows.Forms.ListBox imageList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServer;
    }
}

