using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.DevicesManagement
{
    public partial class UserDevicesForm : Form
    {
        private User user;
        private Form selector;

        public UserDevicesForm(User user, Form selector)
        {
            InitializeComponent();
            this.user = user;
            this.selector = selector;
        }

        private AssignedDevice GetSelectedDevice()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var selectedItem = selectedRow.DataBoundItem as dynamic;
                var device = selectedItem.AssignedDevice as AssignedDevice;
                return device;
            }
            return null;
        }

        private void LoadData()
        {
            var userDevices = UserService.GetUserDevices(user).Select(d => new { AssignedDevice = d, ID = d.Id, Name = d.Device.Name, Category = d.Device.Category.Name }).ToList();
            dataGridView1.DataSource = userDevices;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void UserDevicesForm_Load(object sender, EventArgs e)
        {

            if (user.Role == "Basic")
            {
                btnReport.Enabled = user.ManagerId == null ? false : true;
            }

            LoadData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var assignedDevice = GetSelectedDevice();
            if (assignedDevice == null) return;

            var device = assignedDevice.Device;
            if (device != null)
            {
                var frm = new ReportProblemForm(user, device);
                frm.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frm = (OptionSelectorForm)selector;
            frm.OpenForm(frm);
            this.Close();
        }

        private void btnRetrunDevice_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz zwrócić urządzenie?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var device = GetSelectedDevice();
                if (device != null)
                {
                    DeviceService.ReturnDevice(device);
                    LoadData();
                }
                else
                    MessageBox.Show("Nie wybrano urządzenia do zwrotu!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}