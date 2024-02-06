using Microsoft.IdentityModel.Tokens;
using PAB.Models;
using PAB.Services;
using System.Data;
using System.Printing;

namespace PAB.Forms.UserManagement
{
    public partial class UsersForm : Form
    {
        private User user;
        private List<User> users;

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
            users = UserService.GetAllUsers().Where(u => u.Employee != null).ToList();
            MapUserData(users);
        }

        private void MapUserData(List<User> users)
        {
            var userData = users
                .Select(u => new
                {
                    ID = u.Id,
                    Login = u.Login,
                    Role = u.Role,
                    FullName = u.Employee?.FullName ?? "-",
                    Room = u.Employee?.RoomNumber.ToString() ?? "-",
                    Manager = u.ManagerId.HasValue ? UserService.GetUserById(u.ManagerId.Value)?.Employee?.FullName : "-"
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
                EmployeeService.DeleteEmployee(selectedUser.Employee);
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

        private void FilterData(string searchText)
        {
            var filteredData = users.Where(x => x.Employee.FullName.ToString().Contains(searchText)).ToList();
            MapUserData(filteredData);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData(textBoxSearch.Text);
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz wygenerować raport?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserService.GenerateUsersPDF();
            }
        }
    }
}