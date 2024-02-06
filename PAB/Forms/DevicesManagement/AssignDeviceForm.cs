using Azure.Core;
using PAB.Forms.DevicesManagement;
using PAB.Models;
using PAB.Services;
using System.Windows.Controls;

namespace PAB.Forms.UserManagement
{
    public partial class AssignDeviceForm : Form
    {
        private User user;
        private Device device;
        private Form parentForm;

        public AssignDeviceForm(Device device, User user, Form parentForm)
        {
            this.device = device;
            this.parentForm = parentForm;
            InitializeComponent();
            this.user = user;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBox1.SelectedItem as dynamic;

            if (selectedItem != null)
            {
                var selectedUser = selectedItem.User;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBox1.SelectedItem as dynamic;
            if (selectedItem == null)
            {
                MessageBox.Show("Użytkownik nie istnieje!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = selectedItem.User as User;
            if (user != null && device != null)
            {
                if (device.Quantity != 0)
                {
                    var userDevice = new AssignedDevice(device.Id, user.Id);
                    device.Quantity -= 1;
                    DeviceService.UpdateDevice(device);
                    DeviceService.AssignDevice(userDevice);
                    var frm = (DevicesForm)parentForm;
                    frm.LoadData();
                }
                else
                    MessageBox.Show("Brak urządzenia na stanie!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void AssignDeviceForm_Load(object sender, EventArgs e)
        {
            var users = UserService.GetAllUsers();
            txtDevice.Text = device.Name;
            var managerId = user.Id;

            if (user.Role == "Manager")
            {
                users = users.Where(u => u.ManagerId == user.Id || u.Id == user.Id).ToList();
            }

            foreach (var user in users)
            {
                var fullName = user?.Employee?.FullName;
                if (user.Id == managerId)
                {
                    fullName += " (TY)";
                }
                comboBox1.Items.Add(new { User = user, FullName = fullName });
            }

            comboBox1.SelectedIndex = users.FindIndex(u => u.Id == managerId);
            comboBox1.DisplayMember = "FullName";
        }
    }
}