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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            btnDeleteUser = new FontAwesome.Sharp.IconButton();
            btnEditUser = new FontAwesome.Sharp.IconButton();
            btnReport = new FontAwesome.Sharp.IconButton();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Right;
            btnReport.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnReport.IconColor = Color.Black;
            btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReport.IconSize = 40;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(781, 483);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(165, 41);
            btnReport.TabIndex = 12;
            btnReport.Text = "Generuj raport";
            btnReport.TextAlign = ContentAlignment.MiddleRight;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
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
            Controls.Add(btnReport);
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
        private FontAwesome.Sharp.IconButton btnReport;
        private TextBox textBoxSearch;
        private Label label1;
    }
}