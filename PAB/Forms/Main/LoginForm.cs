using PAB.Models;
using PAB.Services;

namespace PAB.Forms.Main
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var role = string.Empty;

            var loggedUser = UserService.Login(login, password);

            if (loggedUser != null)
            {
                role = loggedUser.Role;
                if (role == "Admin")
                {
                    var frm = new AdminForm(loggedUser);
                    frm.Show();
                }
                if (role == "Manager")
                {
                    var frm = new ManagerForm();
                    frm.Show();
                }
                if (role == "Basic")
                {
                    var frm = new BasicUserForm();
                    frm.Show();
                }

                this.Hide();
            }
            else
                MessageBox.Show("B³êdny login lub has³o. Spróbuj ponownie.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}