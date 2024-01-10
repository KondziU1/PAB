using Azure.Core;
using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class ReportDetailsForm : Form
    {
        private Report report;
        private Form parentForm;

        public ReportDetailsForm(Report report, Form parentForm)
        {
            this.parentForm = parentForm;
            this.report = report;
            InitializeComponent();
        }



        private void ReportDetailsForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Zrealizowane");
            comboBox1.Items.Add("W realizacji");
            comboBox1.Items.Add("Wstrzymane");

            comboBox1.Text = report.Status;

            var user = UserService.GetUserById(report.User_ID);
            var device = DeviceService.GetDeviceById((report.Device_ID));
            var problem = ReportService.GetProblemTypeById(report.ProblemType_ID);
            txtApplicant.Text = user.Login;
            txtDevice.Text = device.Name;
            txtProblem.Text = problem.Name;
            rtxtReason.Text = report.Description;

        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            report.Status = comboBox1.Text;
            ReportService.UpdateReport(report);
            var frm = (ReportsForm)parentForm;
            frm.LoadData();
        }
    }
}