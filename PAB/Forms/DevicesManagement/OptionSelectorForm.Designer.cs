namespace PAB.Forms.DevicesManagement
{
    partial class OptionSelectorForm
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
            btnEmployeeDevices = new FontAwesome.Sharp.IconButton();
            btnDevices = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btnEmployeeDevices
            // 
            btnEmployeeDevices.Anchor = AnchorStyles.None;
            btnEmployeeDevices.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEmployeeDevices.IconColor = Color.Black;
            btnEmployeeDevices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmployeeDevices.Location = new Point(52, 46);
            btnEmployeeDevices.Name = "btnEmployeeDevices";
            btnEmployeeDevices.RightToLeft = RightToLeft.Yes;
            btnEmployeeDevices.Size = new Size(356, 39);
            btnEmployeeDevices.TabIndex = 0;
            btnEmployeeDevices.Text = "Mój sprzęt";
            btnEmployeeDevices.UseVisualStyleBackColor = true;
            btnEmployeeDevices.Click += btnEmployeeDevices_Click;
            // 
            // btnDevices
            // 
            btnDevices.Anchor = AnchorStyles.None;
            btnDevices.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDevices.IconColor = Color.Black;
            btnDevices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDevices.Location = new Point(52, 111);
            btnDevices.Name = "btnDevices";
            btnDevices.RightToLeft = RightToLeft.Yes;
            btnDevices.Size = new Size(356, 39);
            btnDevices.TabIndex = 1;
            btnDevices.Text = "Dostępny sprzęt firmowy";
            btnDevices.UseVisualStyleBackColor = true;
            btnDevices.Click += btnDevices_Click;
            // 
            // OptionSelectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(500, 283);
            Controls.Add(btnDevices);
            Controls.Add(btnEmployeeDevices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OptionSelectorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OptionSelectorForm";
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEmployeeDevices;
        private FontAwesome.Sharp.IconButton btnDevices;
    }
}