using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class ReportsForm : Form
    {
        User user;
        public ReportsForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        internal void LoadData()
        {
            var reports = ReportService.GetAllReports().Where(r => r.Status != "Zrealizowane" && r.Manager_id == user.Id).ToList();
            dataGridView1.DataSource = reports;
            dataGridView1.Columns[2].Visible = false;
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
            var user = UserService.GetUserById(report.User_ID);
            var device = DeviceService.GetDeviceById(report.Device_ID);

            string message = $"Zgłoszenie urządzenia: {device.Name} zostało: {report.Status}";
            NotificationService.SendNotificationToUser(message, user);
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