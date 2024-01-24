namespace PAB.Forms.UserManagement
{
    partial class EditUserForm
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
            comboBoxRole = new ComboBox();
            btnSave = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            cbManager = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(86, 131);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(184, 23);
            comboBoxRole.TabIndex = 17;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 35;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(60, 221);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(210, 38);
            btnSave.TabIndex = 16;
            btnSave.Text = "Zapisz zmiany";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 134);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 15;
            label4.Text = "Rola:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 90);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 14;
            label3.Text = "Hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 42);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 13;
            label2.Text = "Login:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(86, 39);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(184, 23);
            textBoxLogin.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(86, 87);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(184, 23);
            textBoxPassword.TabIndex = 11;
            // 
            // cbManager
            // 
            cbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManager.Enabled = false;
            cbManager.FormattingEnabled = true;
            cbManager.Location = new Point(86, 172);
            cbManager.Name = "cbManager";
            cbManager.Size = new Size(184, 23);
            cbManager.TabIndex = 19;
            cbManager.SelectedIndexChanged += cbManager_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 175);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 18;
            label5.Text = "Przełożony:";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(311, 271);
            Controls.Add(cbManager);
            Controls.Add(label5);
            Controls.Add(comboBoxRole);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += EditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRole;
        private FontAwesome.Sharp.IconButton btnSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private ComboBox cbManager;
        private Label label5;
    }
}