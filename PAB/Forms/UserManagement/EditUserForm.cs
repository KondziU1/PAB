using PAB.Models;
using PAB.Services;
using System.Data;

namespace PAB.Forms.UserManagement
{
    public partial class EditUserForm : Form
    {
        private User user;
        private Form parentForm;
        private ManagerData manager;

        public EditUserForm(User user, Form parentForm)
        {
            this.user = user;
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("Manager");
            comboBoxRole.Items.Add("Basic");

            GetManagerData().ForEach(d => cbManager.Items.Add(d));
            LoadUserData(user);

            cbManager.DisplayMember = "FullName";
            cbManager.ValueMember = "Id";
            cbManager.SelectedItem = null;

            if (user.Role == "Basic")
            {
                cbManager.Enabled = true;
                manager = GetManagerData().FirstOrDefault(m => m.Id == user.ManagerId);

                if (manager != null)
                {
                    var item = cbManager.Items.Cast<ManagerData>().FirstOrDefault(m => m.Id == manager.Id);
                    cbManager.SelectedItem = item;
                }
            }
        }

        private List<ManagerData> GetManagerData()
        {
            var managerData = UserService.GetAllUsers()
            .Where(u => u.Role == "Manager")
            .Select(u => new ManagerData
            {
                Id = u.Id,
                FullName = u.Employee.FullName
            })
            .ToList();

            return managerData;
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

            if (manager != null && manager.Id != user.ManagerId)
            {
                user.ManagerId = manager.Id;
                anyFieldChanged = true;
            }

            if (user.Role == "Basic" && cbManager.SelectedItem == null)
            {
                MessageBox.Show("Proszę o wybór przełożonego!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (anyFieldChanged)
            {
                if (user.Role != "Basic")
                    user.ManagerId = null;

                UserService.UpdateUser(user);
                MessageBox.Show("Zaktualizowano użytkownika.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            var frm = (UsersForm)parentForm;
            frm.LoadData();
            this.Close();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.Text == "Basic")
            {
                cbManager.Enabled = true;

                var managerToRemove = GetManagerData().FirstOrDefault(m => m.Id == user.Id);

                if (managerToRemove != null)
                {
                    var itemToRemove = cbManager.Items.Cast<ManagerData>().FirstOrDefault(m => m.Id == managerToRemove.Id);
                    cbManager.Items.Remove(itemToRemove);
                }
            }
            else
            {
                cbManager.SelectedItem = null;
                cbManager.Enabled = false;
            }
        }

        private void cbManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager = (ManagerData)cbManager.SelectedItem;
        }
    }
}