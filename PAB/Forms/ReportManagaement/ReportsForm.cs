using PAB.Models;
using PAB.Services;
using System.Data;

namespace PAB.Forms.UserManagement
{
    public partial class ReportsForm : Form
    {
        private User user;

        public ReportsForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        internal void LoadData()
        {
            var reports = ReportService.GetAllReports();
            if (user.Role == "Admin")
            {
                reports = reports.Where(r => r.Status != "Zrealizowane" && r.User.Role == "Manager").ToList();
            }
            else
            {
                reports = reports.Where(r => r.Status != "Zrealizowane" && r.ManagerId == user.Id).ToList();
            }
            
            dataGridView1.DataSource = reports;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private Report GetSelectedReport()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var report = (Report)selectedRow.DataBoundItem;
                return report;
            }
            return null;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Notify(Report report)
        {
            string message = $"Zgłoszenie urządzenia: {report.Device.Name} zostało: {report.Status}";
            NotificationService.SendNotificationToUser(message, report.User);
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            var report = GetSelectedReport();
            if (report == null) return;

            if (report.Status == "Wysłane")
            {
                report.Status = "Otworzone";
                ReportService.UpdateReport(report);
                LoadData();

                Notify(report);
            }

            var frm = new ReportDetailsForm(report, this);
            frm.ShowDialog();
        }
    }
}