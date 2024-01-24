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
            cbEmployee = new ComboBox();
            label1 = new Label();
            cbManager = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(78, 89);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(184, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(78, 41);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(184, 23);
            textBoxLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 44);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 92);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Hasło:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 136);
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
            btnAddUser.Location = new Point(52, 251);
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
            comboBoxRole.Location = new Point(78, 133);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(184, 23);
            comboBoxRole.TabIndex = 10;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // cbEmployee
            // 
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(78, 173);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(184, 23);
            cbEmployee.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 176);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 11;
            label1.Text = "Pracownik:";
            // 
            // cbManager
            // 
            cbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManager.Enabled = false;
            cbManager.FormattingEnabled = true;
            cbManager.Location = new Point(78, 212);
            cbManager.Name = "cbManager";
            cbManager.Size = new Size(184, 23);
            cbManager.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 215);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Przełożony:";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(311, 301);
            Controls.Add(cbManager);
            Controls.Add(label5);
            Controls.Add(cbEmployee);
            Controls.Add(label1);
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
        private ComboBox cbEmployee;
        private Label label1;
        private ComboBox cbManager;
        private Label label5;
    }
}