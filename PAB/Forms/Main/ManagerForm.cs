using PAB.Forms.DevicesManagement;
using PAB.Forms.UserManagement;
using PAB.Models;

namespace PAB.Forms.Main
{
    public partial class ManagerForm : Form
    {
        private User user;

        public ManagerForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelLogin.Text = user.Login;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            frm.Show();
            this.Dispose();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var frm = new UsersForm();
            OpenFormInPanel(frm);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
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
            var frm = new OptionSelectorForm(this);
            OpenFormInPanel(frm);
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frm = new SettingsForm();
            OpenFormInPanel(frm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frm = new ReportsForm();
            OpenFormInPanel(frm);
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            var frm = new RequestsForm();
            OpenFormInPanel(frm);
        }
    }
}