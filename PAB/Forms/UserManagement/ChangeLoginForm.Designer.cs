﻿namespace PAB.Forms.UserManagement
{
    partial class ChangeLoginForm
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
            btnConfirm = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnConfirm.IconColor = Color.Black;
            btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirm.IconSize = 45;
            btnConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirm.Location = new Point(133, 193);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(183, 45);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Zatwierdź zmiany";
            btnConfirm.TextAlign = ContentAlignment.MiddleRight;
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 123);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 12;
            label3.Text = "Podaj hasło:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 55);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 10;
            label1.Text = "Nowy login:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 7;
            // 
            // ChangeLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(470, 322);
            Controls.Add(btnConfirm);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeLoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangeLoginForm";
            Load += ChangeLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnConfirm;
        private Label label3;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox1;
    }
}