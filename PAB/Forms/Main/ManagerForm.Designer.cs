namespace PAB.Forms.Main
{
    partial class ManagerForm
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
            labelLogin = new Label();
            panelMenu = new Panel();
            btnRequests = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnHome = new FontAwesome.Sharp.IconButton();
            btnSignOut = new FontAwesome.Sharp.IconButton();
            btnDevices = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            panelForm = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelLogin.Location = new Point(77, 139);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(41, 17);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.WhiteSmoke;
            panelMenu.BackgroundImageLayout = ImageLayout.None;
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnRequests);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(iconPictureBox1);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnSignOut);
            panelMenu.Controls.Add(btnDevices);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(labelLogin);
            panelMenu.Location = new Point(22, 51);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 574);
            panelMenu.TabIndex = 8;
            // 
            // btnRequests
            // 
            btnRequests.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btnRequests.IconColor = Color.Black;
            btnRequests.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRequests.IconSize = 35;
            btnRequests.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequests.Location = new Point(27, 300);
            btnRequests.Name = "btnRequests";
            btnRequests.Size = new Size(141, 42);
            btnRequests.TabIndex = 8;
            btnRequests.Text = "Wnioski";
            btnRequests.TextAlign = ContentAlignment.MiddleRight;
            btnRequests.UseVisualStyleBackColor = true;
            btnRequests.Click += btnRequests_Click;
            // 
            // btnReports
            // 
            btnReports.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            btnReports.IconColor = Color.Black;
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(27, 348);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(141, 42);
            btnReports.TabIndex = 7;
            btnReports.Text = "Zgłoszenia";
            btnReports.TextAlign = ContentAlignment.MiddleRight;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconSize = 127;
            iconPictureBox1.Location = new Point(13, 9);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(172, 127);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            btnHome.IconColor = Color.Black;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(27, 178);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(141, 44);
            btnHome.TabIndex = 5;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnSignOut.IconColor = Color.Black;
            btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignOut.Location = new Point(27, 499);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(141, 44);
            btnSignOut.TabIndex = 4;
            btnSignOut.Text = "Wyloguj";
            btnSignOut.TextAlign = ContentAlignment.MiddleRight;
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnDevices
            // 
            btnDevices.IconChar = FontAwesome.Sharp.IconChar.Computer;
            btnDevices.IconColor = Color.Black;
            btnDevices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDevices.ImageAlign = ContentAlignment.MiddleLeft;
            btnDevices.Location = new Point(27, 252);
            btnDevices.Name = "btnDevices";
            btnDevices.Size = new Size(141, 42);
            btnDevices.TabIndex = 2;
            btnDevices.Text = "Sprzęt";
            btnDevices.TextAlign = ContentAlignment.MiddleRight;
            btnDevices.UseVisualStyleBackColor = true;
            btnDevices.Click += btnDevices_Click;
            // 
            // btnSettings
            // 
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            btnSettings.IconColor = Color.Black;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(27, 396);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(141, 40);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Ustawienia";
            btnSettings.TextAlign = ContentAlignment.MiddleRight;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.Location = new Point(239, 51);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(974, 574);
            panelForm.TabIndex = 9;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1225, 670);
            Controls.Add(panelForm);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += ManagerForm_FormClosing;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelLogin;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDevices;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private Panel panelForm;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnRequests;
        private FontAwesome.Sharp.IconButton btnReports;
    }
}