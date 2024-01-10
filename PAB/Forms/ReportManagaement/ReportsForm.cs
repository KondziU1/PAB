using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        internal void LoadData()
        {
            var reports = ReportService.GetAllReports().Where(r => r.Status != "Zrealizowane").ToList();
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

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            var report = GetSelectedReport();
            if (report == null) return;

            report.Status = "Otworzone";
            ReportService.UpdateReport(report);
            LoadData();
            var frm = new ReportDetailsForm(report, this);
            frm.ShowDialog();
        }
    }
}