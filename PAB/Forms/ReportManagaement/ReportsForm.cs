using PAB.Models;
using PAB.Services;
using System.Collections.Generic;
using System.Data;

namespace PAB.Forms.UserManagement
{
    public partial class ReportsForm : Form
    {
        private User user;
        private List<Report> reports;

        public ReportsForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        internal void LoadData()
        {
            reports = ReportService.GetAllReports();
            if (user.Role == "Manager")
            {
                reports = reports.Where(r => r.Status != "Zrealizowane" && r.ManagerId == user.Id).ToList();
            }
            else if (user.Role == "Basic")
            {
                reports = reports.Where(r => r.UserId == user.Id).ToList();
            }

            MapReportData(reports);
        }
        private void MapReportData(List<Report> reports)
        {
            var reportData = reports.Select(r => new { Report = r, Number = r.Id, Employee = r.User?.Employee?.FullName, Device = r.Device?.Name, Status = r.Status }).ToList();

            dataGridView1.DataSource = reportData;
            dataGridView1.Columns[0].Visible = false;
        }
        private Report GetSelectedReport()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var selectedItem = selectedRow.DataBoundItem as dynamic;
                var report = selectedItem.Report as Report;
                return report;
            }
            return null;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadData();

            if (user.Role != "Admin")
                btnGeneratePDF.Visible = false;

            if (user.Role == "Basic")
            {
                btnShowReport.Visible = false;
                dataGridView1.Columns[2].Visible = false;
            }

            dataGridView1.Columns[0].Visible = false;
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
        private void FilterData(string searchText)
        {
            var filteredData = reports.Where(x => x.Id.ToString().Contains(searchText)).ToList();
            MapReportData(filteredData);

        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData(textBoxSearch.Text);
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz wygenerować raport?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ReportService.GenerateReportsPDF();
            }
        }
    }
}