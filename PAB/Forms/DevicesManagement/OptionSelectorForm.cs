using PAB.Forms.Main;

namespace PAB.Forms.DevicesManagement
{
    public partial class OptionSelectorForm : Form
    {
        private Form parentForm;

        public OptionSelectorForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        internal void OpenForm(Form frm)
        {
            if (parentForm is BasicUserForm basicUserForm)
            {
                basicUserForm.OpenFormInPanel(frm);
            }
            else if (parentForm is AdminForm adminForm)
            {
                adminForm.OpenFormInPanel(frm);
            }
            else if (parentForm is ManagerForm managerForm)
            {
                managerForm.OpenFormInPanel(frm);
            }
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            var frm = new DevicesForm(parentForm);
            OpenForm(frm);
        }

        private void btnEmployeeDevices_Click(object sender, EventArgs e)
        {
            var frm = new UserDevicesForm(parentForm);
            OpenForm(frm);
        }
    }
}