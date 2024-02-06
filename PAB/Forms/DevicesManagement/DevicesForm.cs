using PAB.Forms.Main;
using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;
using System.Threading;
using System.Xml.Serialization;

namespace PAB.Forms.DevicesManagement
{
    public partial class DevicesForm : Form
    {
        private Form parentForm;
        private User user;
        private List<Device> devices;
        private Form selector;

        public DevicesForm(Form parentForm, User user, Form selector)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.user = user;
            this.selector = selector;
        }

        internal void LoadData()
        {
            devices = DeviceService.GetAllDevices();

            if (devices != null)
            {
                if (parentForm is not AdminForm adminForm)
                    devices = devices.Where(d => d.Quantity > 0).ToList();

                dataGridView1.DataSource = devices;
            }
            else
            {
                MessageBox.Show("Błąd podczas pobierania urządzeń.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            }
            else
            {
                btnGeneratePDF.Visible = false;
            }

            if (parentForm is not BasicUserForm basicUserForm)
            {
                btnPerformAction.IconChar = FontAwesome.Sharp.IconChar.Link;
                btnPerformAction.Text = "Przypisz urządzenie";
            }
            else
            {
                btnPerformAction.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
                btnPerformAction.Text = "Wyślij wniosek o sprzęt";

                if (user.ManagerId == null)
                {
                    btnPerformAction.Enabled = false;
                }
            }

            LoadData();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            var frm = new AddDeviceForm(this);
            frm.ShowDialog();
        }

        private void btnUpdateDevice_Click(object sender, EventArgs e)
        {
            var id = SelectedRowID();
            var device = DeviceService.GetDeviceById(id);
            if (device != null)
            {
                var frm = new EditDeviceForm(device,this);
                frm.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frm = (OptionSelectorForm)selector;
            frm.OpenForm(frm);
            this.Close();
        }

        private void SendRequest()
        {
            var id = SelectedRowID();
            var device = DeviceService.GetDeviceById(id);

            if (device == null) { return; }

            var userRequests = RequestService.GetAllRequests().Where(u => u.UserId == user.Id);
            var isRequestExist = userRequests.Where(r => r.DeviceId == device.Id && r.Status == "Wysłany").Any();

            if (isRequestExist)
            {
                MessageBox.Show("Wniosek o ten sprzęt został już wysłany", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var frm = new SendRequestForm(user, device);
            frm.ShowDialog();
        }

        private void AssignDevice()
        {
            var id = SelectedRowID();
            var device = DeviceService.GetDeviceById(id);

            if (device == null) { return; }

            var frm = new AssignDeviceForm(device, user, this);
            frm.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var text = textBoxSearch.Text.ToLower();
            var filteredDevices = devices.Where(x => x.Name.ToLower().Contains(text)).ToList();
            dataGridView1.DataSource = filteredDevices;
        }

        private void btnPerformAction_Click(object sender, EventArgs e)
        {
            if (parentForm is BasicUserForm)
            {
                SendRequest();
            }
            else
            {
                AssignDevice();
            }
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz wygenerować raport?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeviceService.GenerateDevicesPDF();
            }
        }
    }
}