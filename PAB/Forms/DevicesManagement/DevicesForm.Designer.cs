namespace PAB.Forms.DevicesManagement
{
    partial class DevicesForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            btnAddDevice = new FontAwesome.Sharp.IconButton();
            btnUpdateDevice = new FontAwesome.Sharp.IconButton();
            btnSendRequest = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gray;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(752, 499);
            dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(770, 70);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 8;
            label1.Tag = "";
            label1.Text = "Wyszukaj wg nazwy";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Location = new Point(770, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 9;
            // 
            // btnAddDevice
            // 
            btnAddDevice.Anchor = AnchorStyles.Right;
            btnAddDevice.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddDevice.IconColor = Color.Black;
            btnAddDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddDevice.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddDevice.Location = new Point(770, 181);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.Size = new Size(176, 55);
            btnAddDevice.TabIndex = 10;
            btnAddDevice.Text = "Dodaj sprzęt";
            btnAddDevice.TextAlign = ContentAlignment.MiddleRight;
            btnAddDevice.UseVisualStyleBackColor = true;
            btnAddDevice.Visible = false;
            btnAddDevice.Click += btnAddDevice_Click;
            // 
            // btnUpdateDevice
            // 
            btnUpdateDevice.Anchor = AnchorStyles.Right;
            btnUpdateDevice.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnUpdateDevice.IconColor = Color.Black;
            btnUpdateDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdateDevice.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateDevice.Location = new Point(770, 269);
            btnUpdateDevice.Name = "btnUpdateDevice";
            btnUpdateDevice.Size = new Size(176, 55);
            btnUpdateDevice.TabIndex = 11;
            btnUpdateDevice.Text = "Zaktualizuj";
            btnUpdateDevice.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateDevice.UseVisualStyleBackColor = true;
            btnUpdateDevice.Visible = false;
            btnUpdateDevice.Click += btnUpdateDevice_Click;
            // 
            // btnSendRequest
            // 
            btnSendRequest.Anchor = AnchorStyles.Right;
            btnSendRequest.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnSendRequest.IconColor = Color.Black;
            btnSendRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSendRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnSendRequest.Location = new Point(770, 409);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(176, 89);
            btnSendRequest.TabIndex = 12;
            btnSendRequest.Text = "Wyślij wniosek o sprzęt";
            btnSendRequest.TextAlign = ContentAlignment.MiddleRight;
            btnSendRequest.UseVisualStyleBackColor = true;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.Location = new Point(897, 12);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(49, 44);
            iconButton2.TabIndex = 13;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // DevicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(958, 535);
            Controls.Add(iconButton2);
            Controls.Add(btnSendRequest);
            Controls.Add(btnUpdateDevice);
            Controls.Add(btnAddDevice);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DevicesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UsersForm";
            Load += DevicesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnAddDevice;
        private FontAwesome.Sharp.IconButton btnUpdateDevice;
        private FontAwesome.Sharp.IconButton btnSendRequest;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}