using PAB.Forms.Main;
using PAB.Forms.UserManagement;

namespace PAB.Forms.DevicesManagement
{
    public partial class DevicesForm : Form
    {
        private Form parentForm;

        public DevicesForm(Form target)
        {
            InitializeComponent();
            parentForm = target;
        }

        internal void refresh()
        {
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
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            var frm = new AddDeviceForm();
            frm.ShowDialog();
        }

        private void btnUpdateDevice_Click(object sender, EventArgs e)
        {
            var frm = new UpdateDeviceForm();
            frm.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.OfType<OptionSelectorForm>().FirstOrDefault();
            frm.OpenForm(frm);
            this.Close();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            var frm = new SendRequestForm();
            frm.ShowDialog();
        }
    }
}