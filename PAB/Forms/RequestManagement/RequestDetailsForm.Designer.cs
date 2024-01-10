namespace PAB.Forms.UserManagement
{
    partial class RequestDetailsForm
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
            btnAccept = new FontAwesome.Sharp.IconButton();
            btnReject = new FontAwesome.Sharp.IconButton();
            rtxtReason = new RichTextBox();
            txtApplicant = new TextBox();
            txtDevice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Right;
            btnAccept.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnAccept.IconColor = Color.Black;
            btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAccept.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccept.Location = new Point(422, 81);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(176, 55);
            btnAccept.TabIndex = 11;
            btnAccept.Text = "Akceptuj wniosek";
            btnAccept.TextAlign = ContentAlignment.MiddleRight;
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.Anchor = AnchorStyles.Right;
            btnReject.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            btnReject.IconColor = Color.Black;
            btnReject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReject.ImageAlign = ContentAlignment.MiddleLeft;
            btnReject.Location = new Point(422, 180);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(176, 55);
            btnReject.TabIndex = 12;
            btnReject.Text = "Odrzuć wniosek";
            btnReject.TextAlign = ContentAlignment.MiddleRight;
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // rtxtReason
            // 
            rtxtReason.Enabled = false;
            rtxtReason.Location = new Point(66, 209);
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
            txtDevice.Location = new Point(107, 139);
            txtDevice.Name = "txtDevice";
            txtDevice.Size = new Size(207, 23);
            txtDevice.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 41);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 16;
            label1.Text = "Wnioskoadawca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 121);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 17;
            label2.Text = "Urządzenie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 182);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 18;
            label3.Text = "Powód wniosku:";
            // 
            // RequestDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(610, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDevice);
            Controls.Add(txtApplicant);
            Controls.Add(rtxtReason);
            Controls.Add(btnReject);
            Controls.Add(btnAccept);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RequestDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += RequestsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAccept;
        private FontAwesome.Sharp.IconButton btnReject;
        private RichTextBox rtxtReason;
        private TextBox txtApplicant;
        private TextBox txtDevice;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}