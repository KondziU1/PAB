namespace PAB.Forms.UserManagement
{
    partial class EditDeviceForm
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
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnSubmit.IconColor = Color.Black;
            btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSubmit.IconSize = 30;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(52, 183);
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
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 21;
            label1.Text = "Kategoria:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(80, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(80, 126);
            numericUpDown1.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(184, 23);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 128);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 18;
            label3.Text = "Ilość:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 17;
            label2.Text = "Nazwa:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(80, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(184, 23);
            textBoxName.TabIndex = 16;
            // 
            // EditDeviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(311, 242);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditDeviceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += UpdateDeviceForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private TextBox textBoxName;
    }
}