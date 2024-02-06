namespace PAB.Forms.UserManagement
{
    partial class AddUserForm
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
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            comboBoxRole = new ComboBox();
            cbManager = new ComboBox();
            label5 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(27, 92);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(184, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(27, 44);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(184, 23);
            textBoxLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 29);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 77);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Hasło:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 118);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Rola:";
            // 
            // btnAddUser
            // 
            btnAddUser.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddUser.IconColor = Color.Black;
            btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddUser.IconSize = 30;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(138, 178);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(210, 38);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Dodaj użytkownika";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(27, 136);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(184, 23);
            comboBoxRole.TabIndex = 10;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // cbManager
            // 
            cbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManager.Enabled = false;
            cbManager.FormattingEnabled = true;
            cbManager.Location = new Point(245, 136);
            cbManager.Name = "cbManager";
            cbManager.Size = new Size(184, 23);
            cbManager.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 118);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Przełożony:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(245, 44);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(184, 23);
            txtFullName.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 18;
            label1.Text = "Imię i Nazwisko";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 74);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 19;
            label6.Text = "Numer pokoju:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(245, 93);
            numericUpDown1.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(184, 23);
            numericUpDown1.TabIndex = 20;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(449, 228);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtFullName);
            Controls.Add(cbManager);
            Controls.Add(label5);
            Controls.Add(comboBoxRole);
            Controls.Add(btnAddUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label label2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private ComboBox comboBoxRole;
        private ComboBox cbManager;
        private Label label5;
        private TextBox txtFullName;
        private Label label1;
        private Label label6;
        private NumericUpDown numericUpDown1;
    }
}