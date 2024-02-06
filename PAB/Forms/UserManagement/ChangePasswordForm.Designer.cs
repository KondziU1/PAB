namespace PAB.Forms.UserManagement
{
    partial class ChangePasswordForm
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
            txtOldPass = new TextBox();
            txtNewPass = new TextBox();
            txtNewPass2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConfirm = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(135, 64);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(183, 23);
            txtOldPass.TabIndex = 0;
            txtOldPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(135, 124);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(183, 23);
            txtNewPass.TabIndex = 1;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass2
            // 
            txtNewPass2.Location = new Point(135, 180);
            txtNewPass2.Name = "txtNewPass2";
            txtNewPass2.Size = new Size(183, 23);
            txtNewPass2.TabIndex = 2;
            txtNewPass2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 46);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Stare hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 106);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Nowe hasło:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 162);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 5;
            label3.Text = "Potwierdź hasło:";
            // 
            // btnConfirm
            // 
            btnConfirm.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnConfirm.IconColor = Color.Black;
            btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirm.IconSize = 45;
            btnConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirm.Location = new Point(135, 234);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(183, 45);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Zatwierdź zmiany";
            btnConfirm.TextAlign = ContentAlignment.MiddleRight;
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(470, 322);
            Controls.Add(btnConfirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPass2);
            Controls.Add(txtNewPass);
            Controls.Add(txtOldPass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOldPass;
        private TextBox txtNewPass;
        private TextBox txtNewPass2;
        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnConfirm;
    }
}