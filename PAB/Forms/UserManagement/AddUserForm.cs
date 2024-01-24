using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAB.Models;
using PAB.Services;

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
            var employee = cbEmployee.SelectedItem as Employee;
            var manager = cbManager.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role) || employee == null)
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
            var isUserExists = UserService.IsUserExists(user);

            if (!isUserExists)
            {
                user.Employee_ID = employee.Id;
                user.Manager_ID = (int?)cbManager.SelectedValue;
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
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("Manager");
            comboBoxRole.Items.Add("Basic");

            cbEmployee.DataSource = EmployeeService.GetEmployeesWithoutUser();
            cbEmployee.DisplayMember = "FullName";
            cbEmployee.SelectedItem = null;

            cbManager.DataSource = UserService.GetAllUsers()
            .Where(u => u.Role == "Manager")
            .Select(u => new
            {
                Id = u.Id,
                FullName = EmployeeService.GetEmployeeById((int)u.Employee_ID).FullName
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