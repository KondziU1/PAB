using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAB.Models;
using PAB.Services;
using PAB.Forms.DevicesManagement;

namespace PAB.Forms.UserManagement
{
    public partial class EditDeviceForm : Form
    {
        private Device device;
        public EditDeviceForm(Device device)
        {
            this.device = device;
            InitializeComponent();
        }

        private void UpdateDeviceForm_Load(object sender, EventArgs e)
        {
            var categoryId = device.Category_ID;
            var categories = DeviceService.GetDeviceCategories();
            comboBox1.DataSource = categories;

            var category = categories.FirstOrDefault(c => c.Id == categoryId);
            comboBox1.SelectedItem = category;
            comboBox1.DisplayMember = "Name";

            textBoxName.Text = device.Name;
            numericUpDown1.Value = device.Quantity;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = (DeviceCategory)comboBox1.SelectedItem;
            device.Category_ID = selectedCategory.Id;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            device.Name = textBoxName.Text;
            device.Quantity = (int)numericUpDown1.Value;
            DeviceService.UpdateDevice(device);

            var frm = Application.OpenForms.OfType<DevicesForm>().FirstOrDefault();
            frm.LoadData();
            this.Close();
        }

    }
}