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
    public partial class ChangePasswordForm : Form
    {
        User user;
        public ChangePasswordForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtOldPass.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtNewPass2.Text)){
                MessageBox.Show("Wszystkie pola są wymagane!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserService.VerifyPassword(txtOldPass.Text, user.Password))
            {

                if (txtNewPass.Text == txtNewPass2.Text)
                {
                    var hashedPassword = UserService.HashPassword(txtNewPass.Text);
                    user.Password = hashedPassword;
                    UserService.UpdateUser(user);
                    MessageBox.Show("Hasło zostało zmienione pomyślnie!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Hasła się nie zgadzają!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

            }
            else
                MessageBox.Show("Stare hasło niepoprawne!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}