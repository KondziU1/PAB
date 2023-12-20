namespace PAB.Forms.UserManagement
{
    partial class UpdateDeviceForm
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
            textBoxLogin = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Enabled = false;
            textBoxLogin.Location = new Point(69, 44);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(184, 23);
            textBoxLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 47);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Nazwa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 88);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 6;
            label3.Text = "Ilość:";
            // 
            // btnAddUser
            // 
            btnAddUser.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnAddUser.IconColor = Color.Black;
            btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddUser.IconSize = 30;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(52, 183);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(210, 38);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Zatwierdź";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(71, 86);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(184, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // UpdateDeviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(311, 242);
            Controls.Add(numericUpDown1);
            Controls.Add(btnAddUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateDeviceForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxLogin;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private NumericUpDown numericUpDown1;
    }
}