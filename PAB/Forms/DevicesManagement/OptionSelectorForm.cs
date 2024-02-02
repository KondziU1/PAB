using PAB.Forms.Main;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.DevicesManagement
{
    public partial class OptionSelectorForm : Form
    {
        private User user;
        private Form parentForm;

        public OptionSelectorForm(Form parentForm, User user)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.user = user;
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
            var frm = new DevicesForm(parentForm, user, this);
            OpenForm(frm);
        }

        private void btnEmployeeDevices_Click(object sender, EventArgs e)
        {
            var frm = new UserDevicesForm(user, this);
            OpenForm(frm);
        }

        private void OptionSelectorForm_Load(object sender, EventArgs e)
        {
            if (parentForm is AdminForm adminForm)
                btnDevices.Text = "Sprzęt firmowy";
        }
    }
}