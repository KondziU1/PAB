namespace PAB.Forms.UserManagement
{
    partial class AddDeviceForm
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
            btnAddDevice = new FontAwesome.Sharp.IconButton();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnAddDevice
            // 
            btnAddDevice.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddDevice.IconColor = Color.Black;
            btnAddDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddDevice.IconSize = 30;
            btnAddDevice.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddDevice.Location = new Point(52, 176);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.Size = new Size(210, 38);
            btnAddDevice.TabIndex = 8;
            btnAddDevice.Text = "Dodaj sprzęt";
            btnAddDevice.UseVisualStyleBackColor = true;
            btnAddDevice.Click += btnAddDevice_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(78, 125);
            numericUpDown1.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(184, 23);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 127);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 12;
            label3.Text = "Ilość:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 78);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 11;
            label2.Text = "Nazwa:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(78, 75);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(184, 23);
            textBoxName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 15;
            label1.Text = "Kategoria:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AddDeviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(311, 251);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(btnAddDevice);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddDeviceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddDeviceForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAddDevice;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private ComboBox comboBox1;
    }
}