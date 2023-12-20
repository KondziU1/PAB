using PAB.Forms.Main;
using PAB.Forms.UserManagement;

namespace PAB.Forms.DevicesManagement
{
    public partial class UserDevicesForm : Form
    {
        private Form parentForm;

        public UserDevicesForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
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

        private void UserDevicesForm_Load(object sender, EventArgs e)
        {
            if (parentForm is BasicUserForm basicUserForm)
            {
                btnReport.Enabled = true;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var frm = new ReportProblemForm();
            frm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.OfType<OptionSelectorForm>().FirstOrDefault();
            frm.OpenForm(frm);
            this.Close();
        }
    }
}