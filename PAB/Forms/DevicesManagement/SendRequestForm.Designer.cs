namespace PAB.Forms.UserManagement
{
    partial class SendRequestForm
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
            btnSendRequest = new FontAwesome.Sharp.IconButton();
            rtxtReason = new RichTextBox();
            label1 = new Label();
            labelNote = new Label();
            textBoxLogin = new TextBox();
            SuspendLayout();
            // 
            // btnSendRequest
            // 
            btnSendRequest.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnSendRequest.IconColor = Color.Black;
            btnSendRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSendRequest.IconSize = 35;
            btnSendRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnSendRequest.Location = new Point(47, 228);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(210, 38);
            btnSendRequest.TabIndex = 16;
            btnSendRequest.Text = "Wyślij wniosek";
            btnSendRequest.UseVisualStyleBackColor = true;
            // 
            // rtxtReason
            // 
            rtxtReason.Location = new Point(12, 113);
            rtxtReason.Name = "rtxtReason";
            rtxtReason.Size = new Size(287, 96);
            rtxtReason.TabIndex = 18;
            rtxtReason.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 30);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 19;
            label1.Text = "Nazwa sprzętu:";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(126, 95);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(47, 15);
            labelNote.TabIndex = 20;
            labelNote.Text = "Powód:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Enabled = false;
            textBoxLogin.Location = new Point(59, 48);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(184, 23);
            textBoxLogin.TabIndex = 21;
            // 
            // SendRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(311, 297);
            Controls.Add(textBoxLogin);
            Controls.Add(labelNote);
            Controls.Add(label1);
            Controls.Add(rtxtReason);
            Controls.Add(btnSendRequest);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SendRequestForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSendRequest;
        private RichTextBox rtxtReason;
        private Label label1;
        private Label labelNote;
        private TextBox textBoxLogin;
    }
}