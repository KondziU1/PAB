namespace PAB.Forms.UserManagement
{
    partial class ReportDetailsForm
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
            rtxtReason = new RichTextBox();
            txtApplicant = new TextBox();
            txtDevice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnChangeStatus = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            txtProblem = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // rtxtReason
            // 
            rtxtReason.Enabled = false;
            rtxtReason.Location = new Point(63, 228);
            rtxtReason.Name = "rtxtReason";
            rtxtReason.Size = new Size(294, 98);
            rtxtReason.TabIndex = 13;
            rtxtReason.Text = "";
            // 
            // txtApplicant
            // 
            txtApplicant.Enabled = false;
            txtApplicant.Location = new Point(107, 59);
            txtApplicant.Name = "txtApplicant";
            txtApplicant.Size = new Size(207, 23);
            txtApplicant.TabIndex = 14;
            // 
            // txtDevice
            // 
            txtDevice.Enabled = false;
            txtDevice.Location = new Point(104, 115);
            txtDevice.Name = "txtDevice";
            txtDevice.Size = new Size(207, 23);
            txtDevice.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 41);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 16;
            label1.Text = "Zgłaszający:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 97);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 17;
            label2.Text = "Urządzenie:";
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Right;
            btnChangeStatus.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            btnChangeStatus.IconColor = Color.Black;
            btnChangeStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChangeStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangeStatus.Location = new Point(397, 168);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(176, 55);
            btnChangeStatus.TabIndex = 21;
            btnChangeStatus.Text = "Zmień status";
            btnChangeStatus.TextAlign = ContentAlignment.MiddleRight;
            btnChangeStatus.UseVisualStyleBackColor = true;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(398, 89);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 20;
            label4.Text = "Status zgłoszenia:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(397, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 150);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 23;
            label5.Text = "Rodzaj problemu:";
            // 
            // txtProblem
            // 
            txtProblem.Enabled = false;
            txtProblem.Location = new Point(104, 168);
            txtProblem.Name = "txtProblem";
            txtProblem.Size = new Size(207, 23);
            txtProblem.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 208);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 24;
            label3.Text = "Opis:";
            // 
            // ReportDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(610, 338);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtProblem);
            Controls.Add(btnChangeStatus);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDevice);
            Controls.Add(txtApplicant);
            Controls.Add(rtxtReason);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReportDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += ReportDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtxtReason;
        private TextBox txtApplicant;
        private TextBox txtDevice;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnChangeStatus;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtProblem;
        private Label label3;
    }
}