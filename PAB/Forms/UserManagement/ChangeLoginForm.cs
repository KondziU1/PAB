using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class ChangeLoginForm : Form
    {
        private User user;

        public ChangeLoginForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ChangeLoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Wszystkie pola są wymagane!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserService.VerifyPassword(txtPassword.Text, user.Password))
            {
                user.Login = txtLogin.Text;
                var isUserExists = UserService.IsUserExists(user);

                if (!isUserExists)
                {
                    UserService.UpdateUser(user);
                    MessageBox.Show("Login został zmieniony pomyślnie!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Użytkownik o podanym loginie już istnieje!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Hasło jest niepoprawne!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}