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

            txtApplicant.Text = report.User.Login;
            txtDevice.Text = report.Device.Name;
            txtProblem.Text = report.ProblemType.Name;
            rtxtReason.Text = report.Description;
        }

        private void Notify()
        {
            string message = $"Zgłoszenie urządzenia: {report.Device.Name} {(report.Status == "W realizacji" ? "jest" : "zostało")} {report.Status}";

            NotificationService.SendNotificationToUser(message, report.User);
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Czy na pewno chcesz zmienić status na: {comboBox1.Text}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                report.Status = comboBox1.Text;
                ReportService.UpdateReport(report);

                var frm = (ReportsForm)parentForm;
                frm.LoadData();
                Notify();
                this.Close();
            }
        }
    }
}