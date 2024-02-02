using PAB.Models;
using PAB.Services;
using System.Data;

namespace PAB.Forms.UserManagement
{
    public partial class UsersForm : Form
    {
        User user;
        public UsersForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        internal void LoadData()
        {
            var users = UserService.GetAllUsers();

            var userData = users
                .Select(u => new
                {
                    ID = u.Id,
                    Login = u.Login,
                    Role = u.Role,
                    FullName = u?.Employee?.FullName ?? "-",
                    Room = u?.Employee?.RoomNumber.ToString() ?? "-"
                }).ToList();

            dataGridView1.DataSource = userData;
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var frm = new AddUserForm(this);
            frm.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var id = SelectedRowID();
            var selectedUser = UserService.GetUserById(id);
            if (selectedUser == null) return;

            if ((selectedUser.Role == "Admin" && user.Id != 1) || selectedUser.Id == user.Id)
            {
                MessageBox.Show("Nie można usunać konta administratora!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = MessageBox.Show($"Czy chcesz usunąć użytkownika: {selectedUser.Login} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                UserService.DeleteUser(selectedUser);
                LoadData();
            }
        }

        private int SelectedRowID()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                return id;
            }
            return 0;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var id = SelectedRowID();
            var selectedUser = UserService.GetUserById(id);
            if (selectedUser == null) return;

            if (selectedUser.Role == "Admin" && selectedUser.Id != user.Id && user.Id != 1)
            {
                MessageBox.Show("Nie można edytować konta innego administratora!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new EditUserForm(selectedUser, this);
            frm.ShowDialog();
        }
    }
}