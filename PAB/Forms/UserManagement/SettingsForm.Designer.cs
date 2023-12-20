namespace PAB.Forms.UserManagement
{
    partial class SettingsForm
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
            btnChangePassword = new FontAwesome.Sharp.IconButton();
            btnChangeLogin = new FontAwesome.Sharp.IconButton();
            panelForm = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnChangePassword
            // 
            btnChangePassword.IconChar = FontAwesome.Sharp.IconChar.None;
            btnChangePassword.IconColor = Color.Black;
            btnChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChangePassword.Location = new Point(327, 79);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(190, 46);
            btnChangePassword.TabIndex = 0;
            btnChangePassword.Text = "Zmień hasło";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnChangeLogin
            // 
            btnChangeLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            btnChangeLogin.IconColor = Color.Black;
            btnChangeLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChangeLogin.Location = new Point(523, 79);
            btnChangeLogin.Name = "btnChangeLogin";
            btnChangeLogin.Size = new Size(190, 46);
            btnChangeLogin.TabIndex = 1;
            btnChangeLogin.Text = "Zmień login";
            btnChangeLogin.UseVisualStyleBackColor = true;
            btnChangeLogin.Click += btnChangeLogin_Click;
            // 
            // panelForm
            // 
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Location = new Point(263, 131);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(450, 297);
            panelForm.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 46;
            iconPictureBox1.Location = new Point(263, 79);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(58, 46);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(958, 535);
            Controls.Add(iconPictureBox1);
            Controls.Add(panelForm);
            Controls.Add(btnChangeLogin);
            Controls.Add(btnChangePassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnChangePassword;
        private FontAwesome.Sharp.IconButton btnChangeLogin;
        private Panel panelForm;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}