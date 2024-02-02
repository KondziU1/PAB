using PAB.Models;

namespace PAB.Forms.UserManagement
{
    public partial class SettingsForm : Form
    {
        private User user;

        public SettingsForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public void OpenFormInPanel(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelForm.Controls.Clear();
            panelForm.Controls.Add(frm);
            frm.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var frm = new ChangePasswordForm(user);
            OpenFormInPanel(frm);
        }

        private void btnChangeLogin_Click(object sender, EventArgs e)
        {
            var frm = new ChangeLoginForm(user);
            OpenFormInPanel(frm);
        }
    }
}