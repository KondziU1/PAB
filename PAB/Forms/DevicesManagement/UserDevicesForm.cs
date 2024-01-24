using PAB.Forms.Main;
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

        private int SelectedRowID()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                return id;
            }
            return 0;
        }

        private void LoadData()
        {
            var userDevices = UserService.GetUserDevices(user).Select(d => new { ID = d.Id, Name = d.Name, Category = DeviceService.GetDeviceCategoryById(d.Category_ID).Name }).ToList();
            dataGridView1.DataSource = userDevices;
            dataGridView1.Columns[0].Visible = false;
        }

        private void UserDevicesForm_Load(object sender, EventArgs e)
        {
            if (user.Role == "Basic")
            {
                btnReport.Enabled = true;
            }
            else
            {
                return;
            }

            LoadData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var deviceID = SelectedRowID();
            Device device = DeviceService.GetDeviceById(deviceID);
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
    }
}