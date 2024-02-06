using PAB.Models;
using PAB.Services;
using System.Data;

namespace PAB.Forms.UserManagement
{
    public partial class AddUserForm : Form
    {
        private Form parentForm;

        public AddUserForm(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var role = comboBoxRole.Text;
            var manager = cbManager.Text;
            var fullName = txtFullName.Text;
            var room = (int)numericUpDown1.Value;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(fullName) || room == 0)
            {
                MessageBox.Show("Wszystkie pola są wymagane!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(manager) && role == "Basic")
            {
                MessageBox.Show("Proszę o wybór przełożonego!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hashedPassword = UserService.HashPassword(password);
            var user = new User(login, hashedPassword, role);
            var employee = new Employee(fullName, room);
            var isUserExists = UserService.IsUserExists(user);

            if (!isUserExists)
            {
                EmployeeService.AddEmployee(employee);
                user.ManagerId = (int?)cbManager.SelectedValue;
                user.EmployeeId = employee.Id;

                UserService.AddUser(user);

                MessageBox.Show("Dodano nowego użytkownika.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var frm = (UsersForm)parentForm;
                frm.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Użytkownik o podanym loginie już istnieje!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Controls[0].Visible = false;
            comboBoxRole.Items.Add("Manager");
            comboBoxRole.Items.Add("Basic");

            cbManager.DataSource = UserService.GetAllUsers()
            .Where(u => u.Role == "Manager")
            .Select(u => new
            {
                Id = u.Id,
                FullName = u.Employee?.FullName
            })
            .ToList();

            cbManager.DisplayMember = "FullName";
            cbManager.ValueMember = "Id";
            cbManager.SelectedItem = null;
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.Text == "Basic")
            {
                cbManager.Enabled = true;
            }
            else
            {
                cbManager.SelectedItem = null;
                cbManager.Enabled = false;
            }
        }
    }
}