using Microsoft.VisualBasic.Logging;
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
    public partial class EditUserForm : Form
    {
        User user;
        public EditUserForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("Manager");
            comboBoxRole.Items.Add("Basic");

            LoadUserData(user);
        }
        public void LoadUserData(User user)
        {
            textBoxLogin.Text = user.Login;
            comboBoxRole.SelectedItem = user.Role;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool anyFieldChanged = false;

            if (textBoxPassword.Text != string.Empty)
            {
                var hashedPassword = UserService.HashPassword(textBoxPassword.Text);
                if (hashedPassword != user.Password)
                {
                    user.Password = hashedPassword;
                    anyFieldChanged = true;
                }
            }

            if (textBoxLogin.Text != user.Login)
            {
                user.Login = textBoxLogin.Text;
                anyFieldChanged = true;
            }

            if (comboBoxRole.Text != user.Role)
            {
                user.Role = comboBoxRole.Text;
                anyFieldChanged = true;
            }

            if (anyFieldChanged)
            {
                UserService.UpdateUser(user);
                MessageBox.Show("Zaktualizowano użytkownika.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            var frm = Application.OpenForms.OfType<RequestsForm>().FirstOrDefault();
            frm.refresh();
            this.Close();
        }

    }
}
