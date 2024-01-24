using PAB.Forms.Main;
using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;
using System.Windows.Navigation;

namespace PAB.Forms.DevicesManagement
{
    public partial class DevicesForm : Form
    {
        private Form parentForm;
        private User user;
        private List<Device> devices;
        Form selector;

        public DevicesForm(Form parentForm, User user, Form selector)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.user = user;
            this.selector = selector;
        }

        internal void LoadData()
        {
            devices = DeviceService.GetAllDevices().Where(d => d.Quantity >0).ToList();
            dataGridView1.DataSource = devices;
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

        private void DevicesForm_Load(object sender, EventArgs e)
        {
            if (parentForm is AdminForm adminForm)
            {
                btnAddDevice.Visible = true;
                btnUpdateDevice.Visible = true;
                btnSendRequest.Enabled = false;
            }
            else if (parentForm is ManagerForm managerForm)
            {
                btnSendRequest.Enabled = false;
            }

            LoadData();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            var frm = new AddDeviceForm();
            frm.ShowDialog();
        }

        private void btnUpdateDevice_Click(object sender, EventArgs e)
        {
            var id = SelectedRowID();
            var device = DeviceService.GetDeviceById(id);
            var frm = new EditDeviceForm(device);
            frm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frm = (OptionSelectorForm)selector;
            frm.OpenForm(frm);
            this.Close();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            var id = SelectedRowID();
            var device = DeviceService.GetDeviceById(id);
            var userRequests = RequestService.GetAllRequests().Where(u => u.User_ID == user.Id);
            var isRequestExist = userRequests.Where(r => r.Device_ID == device.Id).Any();

            if (isRequestExist)
            {
                MessageBox.Show("Wniosek o ten sprzęt został już wysłany", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var frm = new SendRequestForm(user, device);
            frm.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var text = textBoxSearch.Text.ToLower();
            var filteredDevices = devices.Where(x => x.Name.ToLower().Contains(text)).ToList();
            dataGridView1.DataSource = filteredDevices;
        }


    }
}