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
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label1 = new Label();
            txtFullName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(27, 127);
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
            btnSave.Location = new Point(119, 167);
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
            label4.Location = new Point(27, 109);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 15;
            label4.Text = "Rola:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 65);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 14;
            label3.Text = "Hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 17);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 13;
            label2.Text = "Login:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(27, 35);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(184, 23);
            textBoxLogin.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(27, 83);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(184, 23);
            textBoxPassword.TabIndex = 11;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // cbManager
            // 
            cbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManager.Enabled = false;
            cbManager.FormattingEnabled = true;
            cbManager.Location = new Point(240, 127);
            cbManager.Name = "cbManager";
            cbManager.Size = new Size(184, 23);
            cbManager.TabIndex = 19;
            cbManager.SelectedIndexChanged += cbManager_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 109);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 18;
            label5.Text = "Przełożony:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(240, 83);
            numericUpDown1.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(184, 23);
            numericUpDown1.TabIndex = 24;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 64);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 23;
            label6.Text = "Numer pokoju:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 17);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 22;
            label1.Text = "Imię i Nazwisko";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(240, 35);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(184, 23);
            txtFullName.TabIndex = 21;
            // 
            // EditUserForm
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label1;
        private TextBox txtFullName;
    }
}