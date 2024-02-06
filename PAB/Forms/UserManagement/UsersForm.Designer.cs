namespace PAB.Forms.UserManagement
{
    partial class UsersForm
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
            btnAddUser = new FontAwesome.Sharp.IconButton();
            btnDeleteUser = new FontAwesome.Sharp.IconButton();
            btnEditUser = new FontAwesome.Sharp.IconButton();
            btnGeneratePDF = new FontAwesome.Sharp.IconButton();
            textBoxSearch = new TextBox();
            label1 = new Label();
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
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Right;
            btnAddUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAddUser.IconColor = Color.Black;
            btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(781, 141);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(165, 60);
            btnAddUser.TabIndex = 9;
            btnAddUser.Text = "Dodaj użytkownika";
            btnAddUser.TextAlign = ContentAlignment.MiddleRight;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Anchor = AnchorStyles.Right;
            btnDeleteUser.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            btnDeleteUser.IconColor = Color.Black;
            btnDeleteUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteUser.Location = new Point(781, 228);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(165, 60);
            btnDeleteUser.TabIndex = 10;
            btnDeleteUser.Text = "Usuń użytkownika";
            btnDeleteUser.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Anchor = AnchorStyles.Right;
            btnEditUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnEditUser.IconColor = Color.Black;
            btnEditUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditUser.Location = new Point(781, 317);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(165, 60);
            btnEditUser.TabIndex = 11;
            btnEditUser.Text = "Edytuj użytkownika";
            btnEditUser.TextAlign = ContentAlignment.MiddleRight;
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnGeneratePDF
            // 
            btnGeneratePDF.Anchor = AnchorStyles.Right;
            btnGeneratePDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnGeneratePDF.IconColor = Color.Black;
            btnGeneratePDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGeneratePDF.IconSize = 40;
            btnGeneratePDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnGeneratePDF.Location = new Point(781, 483);
            btnGeneratePDF.Name = "btnGeneratePDF";
            btnGeneratePDF.Size = new Size(165, 41);
            btnGeneratePDF.TabIndex = 12;
            btnGeneratePDF.Text = "Generuj raport";
            btnGeneratePDF.TextAlign = ContentAlignment.MiddleRight;
            btnGeneratePDF.UseVisualStyleBackColor = true;
            btnGeneratePDF.Click += btnGeneratePDF_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Right;
            textBoxSearch.Location = new Point(779, 54);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(167, 23);
            textBoxSearch.TabIndex = 14;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(779, 33);
            label1.Name = "label1";
            label1.Size = new Size(141, 18);
            label1.TabIndex = 13;
            label1.Tag = "";
            label1.Text = "Wyszukaj pracownika:";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(958, 535);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(btnGeneratePDF);
            Controls.Add(btnEditUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UsersForm";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private FontAwesome.Sharp.IconButton btnDeleteUser;
        private FontAwesome.Sharp.IconButton btnEditUser;
        private FontAwesome.Sharp.IconButton btnGeneratePDF;
        private TextBox textBoxSearch;
        private Label label1;
    }
}