namespace PAB.Forms.Main
{
    partial class AdminForm
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnHome = new FontAwesome.Sharp.IconButton();
            btnSignOut = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnUsers = new FontAwesome.Sharp.IconButton();
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
            panelMenu.Controls.Add(iconPictureBox1);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnSignOut);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(labelLogin);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Location = new Point(22, 51);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 574);
            panelMenu.TabIndex = 8;
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
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Computer;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(27, 314);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(141, 42);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "Sprzęt";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Gears;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(27, 380);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(141, 40);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "Ustawienia";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.White;
            btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsers.IconColor = Color.Black;
            btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(27, 252);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(141, 44);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Użytkownicy";
            btnUsers.TextAlign = ContentAlignment.MiddleRight;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.Location = new Point(239, 51);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(974, 574);
            panelForm.TabIndex = 9;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1225, 670);
            Controls.Add(panelForm);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += AdminForm_FormClosing;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelLogin;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private Panel panelForm;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}