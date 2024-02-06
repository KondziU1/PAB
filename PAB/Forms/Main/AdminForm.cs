using PAB.Forms.DevicesManagement;
using PAB.Forms.UserManagement;
using PAB.Models;

namespace PAB.Forms.Main
{
    public partial class AdminForm : Form
    {
        private User user;

        public AdminForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelLogin.Text = user.Login;

            var frm = new HomeForm(user);
            OpenFormInPanel(frm);
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            frm.Show();
            this.Dispose();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var frm = new UsersForm(user);
            OpenFormInPanel(frm);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frm = new HomeForm(user);
            OpenFormInPanel(frm);
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

        private void btnDevices_Click(object sender, EventArgs e)
        {
            var frm = new OptionSelectorForm(this, user);
            OpenFormInPanel(frm);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frm = new SettingsForm(user);
            OpenFormInPanel(frm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frm = new ReportsForm(user);
            OpenFormInPanel(frm);
        }
        private void btnRequests_Click(object sender, EventArgs e)
        {
            var frm = new RequestsForm(user);
            OpenFormInPanel(frm);
        }
    }
}