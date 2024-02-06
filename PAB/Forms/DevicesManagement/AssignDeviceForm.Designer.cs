namespace PAB.Forms.UserManagement
{
    partial class AssignDeviceForm
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
            btnSubmit = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txtDevice = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnSubmit.IconColor = Color.Black;
            btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSubmit.IconSize = 30;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(52, 131);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(210, 38);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Zatwierdź";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 85);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 21;
            label1.Text = "Użytkownik:";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 51);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 17;
            label2.Text = "Urządzenie:";
            // 
            // txtDevice
            // 
            txtDevice.Enabled = false;
            txtDevice.Location = new Point(78, 43);
            txtDevice.Name = "txtDevice";
            txtDevice.Size = new Size(184, 23);
            txtDevice.TabIndex = 16;
            // 
            // AssignDeviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(318, 192);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(txtDevice);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AssignDeviceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AssignDeviceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSubmit;
        private Label label1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private TextBox txtDevice;
    }
}