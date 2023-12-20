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
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var role = comboBoxRole.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Wszystkie pola są wymagane!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hashedPassword = UserService.HashPassword(password);
            var user = new User(login, hashedPassword, role);
            var isUserExists = UserService.IsUserExists(user);

            if (!isUserExists)
            {
                UserService.AddUser(user);
                MessageBox.Show("Dodano nowego użytkownika.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var frm = Application.OpenForms.OfType<RequestsForm>().FirstOrDefault();
                frm.refresh();
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
        }
    }
}
