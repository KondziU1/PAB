﻿using PAB.Forms.DevicesManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class AddDeviceForm : Form
    {
        private string name;
        private int quantity, categoryId;

        public AddDeviceForm()
        {
            InitializeComponent();
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            quantity = (int)numericUpDown1.Value;

            Device device = new Device(name, "Nowy", quantity, categoryId);

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Proszę wprowadzić nazwę urządzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Proszę wprowadzić prawidłową ilość.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DeviceService.AddDevice(device);
            var frm = Application.OpenForms.OfType<DevicesForm>().FirstOrDefault();
            frm.LoadData();
            this.Close();
        }

        private void AddDeviceForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = DeviceService.GetDeviceCategories();
            comboBox1.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = (DeviceCategory)comboBox1.SelectedItem;
            categoryId = selectedCategory.Id;
        }
    }
}