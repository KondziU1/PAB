using PAB.Forms.DevicesManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class EditDeviceForm : Form
    {
        private Device device;
        Form parentForm;
        public EditDeviceForm(Device device, Form parentForm)
        {
            this.parentForm = parentForm;
            this.device = device;
            InitializeComponent();
        }

        private void UpdateDeviceForm_Load(object sender, EventArgs e)
        {
            var categoryId = device.CategoryId;
            var categories = DeviceService.GetDeviceCategories();
            comboBox1.DataSource = categories;

            var category = categories.FirstOrDefault(c => c.Id == categoryId);

            if (category != null)
            {
                comboBox1.SelectedItem = category;
                comboBox1.DisplayMember = "Name";
            }

            textBoxName.Text = device.Name;
            numericUpDown1.Value = device.Quantity;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = (DeviceCategory)comboBox1.SelectedItem;
            device.CategoryId = selectedCategory.Id;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            device.Name = textBoxName.Text;
            device.Quantity = (int)numericUpDown1.Value;
            DeviceService.UpdateDevice(device);

            var frm = (DevicesForm)parentForm;
            frm.LoadData();
            this.Close();
        }
    }
}