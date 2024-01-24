using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        internal void LoadData()
        {
            var users = UserService.GetAllUsers();
            var employees = EmployeeService.GetAllEmployees();

            //var userData = users
            //    .Select(u =>
            //    new { ID = u.Id,
            //        Login = u.Login,
            //        Role = u.Role,
            //        FullName = employees.FirstOrDefault(e => e.Id == u.Employee_ID)?.FullName ?? "-",
            //        Room = employees.FirstOrDefault(e => e.Id == u.Employee_ID)?.RoomNumber.ToString() ?? "-"
            //    })
            //    .ToList();

            var userData = employees.Join(users,
                        employee => employee.Id,
                        user => user.Employee_ID,
                        (employee, user) => new { ID = user.Id, Login = user.Login, Role = user.Role, FullName = employee.FullName, Room = employee.RoomNumber });

            dataGridView1.DataSource = userData.ToList();
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
            var user = UserService.GetUserById(id);
            DialogResult = MessageBox.Show($"Czy chcesz usunąć użytkownika: {user.Login} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                UserService.DeleteUser(user);
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
            var user = UserService.GetUserById(id);
            var frm = new EditUserForm(user, this);
            frm.ShowDialog();
        }
    }
}