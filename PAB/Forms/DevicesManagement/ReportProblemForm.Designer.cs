namespace PAB.Forms.UserManagement
{
    partial class ReportProblemForm
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
            btnSendReport = new FontAwesome.Sharp.IconButton();
            cbRodzajProblemu = new ComboBox();
            rtxtNote = new RichTextBox();
            label1 = new Label();
            labelNote = new Label();
            SuspendLayout();
            // 
            // btnSendReport
            // 
            btnSendReport.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnSendReport.IconColor = Color.Black;
            btnSendReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSendReport.IconSize = 35;
            btnSendReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnSendReport.Location = new Point(47, 228);
            btnSendReport.Name = "btnSendReport";
            btnSendReport.Size = new Size(210, 38);
            btnSendReport.TabIndex = 16;
            btnSendReport.Text = "Wyślij zgłoszenie";
            btnSendReport.UseVisualStyleBackColor = true;
            // 
            // cbRodzajProblemu
            // 
            cbRodzajProblemu.FormattingEnabled = true;
            cbRodzajProblemu.Location = new Point(56, 55);
            cbRodzajProblemu.Name = "cbRodzajProblemu";
            cbRodzajProblemu.Size = new Size(188, 23);
            cbRodzajProblemu.TabIndex = 17;
            // 
            // rtxtNote
            // 
            rtxtNote.Location = new Point(12, 113);
            rtxtNote.Name = "rtxtNote";
            rtxtNote.Size = new Size(287, 96);
            rtxtNote.TabIndex = 18;
            rtxtNote.Text = "(opcjonalne)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 37);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 19;
            label1.Text = "Rodzaj Problemu:";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(126, 95);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(34, 15);
            labelNote.TabIndex = 20;
            labelNote.Text = "Opis:";
            // 
            // ReportProblemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(311, 297);
            Controls.Add(labelNote);
            Controls.Add(label1);
            Controls.Add(rtxtNote);
            Controls.Add(cbRodzajProblemu);
            Controls.Add(btnSendReport);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportProblemForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSendReport;
        private ComboBox cbRodzajProblemu;
        private RichTextBox rtxtNote;
        private Label label1;
        private Label labelNote;
    }
}