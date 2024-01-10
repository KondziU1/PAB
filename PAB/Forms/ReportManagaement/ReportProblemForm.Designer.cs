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
            rtxtDescription = new RichTextBox();
            label1 = new Label();
            labelNote = new Label();
            txtDevice = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSendReport
            // 
            btnSendReport.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnSendReport.IconColor = Color.Black;
            btnSendReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSendReport.IconSize = 35;
            btnSendReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnSendReport.Location = new Point(50, 280);
            btnSendReport.Name = "btnSendReport";
            btnSendReport.Size = new Size(210, 38);
            btnSendReport.TabIndex = 16;
            btnSendReport.Text = "Wyślij zgłoszenie";
            btnSendReport.UseVisualStyleBackColor = true;
            btnSendReport.Click += btnSendReport_Click;
            // 
            // cbRodzajProblemu
            // 
            cbRodzajProblemu.FormattingEnabled = true;
            cbRodzajProblemu.Location = new Point(59, 107);
            cbRodzajProblemu.Name = "cbRodzajProblemu";
            cbRodzajProblemu.Size = new Size(188, 23);
            cbRodzajProblemu.TabIndex = 17;
            cbRodzajProblemu.SelectedIndexChanged += cbRodzajProblemu_SelectedIndexChanged;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(15, 165);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(287, 96);
            rtxtDescription.TabIndex = 18;
            rtxtDescription.Text = "(opcjonalnie)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 89);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 19;
            label1.Text = "Rodzaj Problemu:";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(125, 147);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(34, 15);
            labelNote.TabIndex = 20;
            labelNote.Text = "Opis:";
            // 
            // txtDevice
            // 
            txtDevice.Enabled = false;
            txtDevice.Location = new Point(59, 46);
            txtDevice.Name = "txtDevice";
            txtDevice.Size = new Size(188, 23);
            txtDevice.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 28);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 22;
            label2.Text = "Urządzenie:";
            // 
            // ReportProblemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(311, 332);
            Controls.Add(label2);
            Controls.Add(txtDevice);
            Controls.Add(labelNote);
            Controls.Add(label1);
            Controls.Add(rtxtDescription);
            Controls.Add(cbRodzajProblemu);
            Controls.Add(btnSendReport);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportProblemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ReportProblemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSendReport;
        private ComboBox cbRodzajProblemu;
        private RichTextBox rtxtDescription;
        private Label label1;
        private Label labelNote;
        private TextBox txtDevice;
        private Label label2;
    }
}