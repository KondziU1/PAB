using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class ReportProblemForm : Form
    {
        private int problemId;
        private User user;
        private Device device;

        public ReportProblemForm(User user, Device device)
        {
            this.user = user;
            this.device = device;
            InitializeComponent();
        }

        private void ReportProblemForm_Load(object sender, EventArgs e)
        {
            txtDevice.Text = device.Name;
            cbRodzajProblemu.DataSource = ReportService.GetProblemTypes();
            cbRodzajProblemu.DisplayMember = "Name";
        }

        private void Notify(Report report)
        {
            var employee = user.Employee;

            if (user.Employee == null)
            {
                return;
            }

            string message = $"Nowe zgłoszenie od {employee.FullName}({user.Login})";

            if (user.Role == "Basic")
            {
                var manager = user.Manager;

                if (manager != null)
                {
                    NotificationService.SendNotificationToUser(message, manager);
                }
            }
            else
            {
                NotificationService.SendNotificationToStaff(message);
            }
        }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            var description = rtxtDescription.Text;
            description = description == "(opcjonalnie)" ? null : description;
            var result = MessageBox.Show("Czy na pewno chcesz wysłać zgłoszenie?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var report = new Report(user.Id, description, problemId, device.Id, user.ManagerId, "Wysłane");
                ReportService.AddReport(report);
                Notify(report);
                this.Close();
            }
            else
                return;
        }

        private void cbRodzajProblemu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var problemType = (ProblemType)cbRodzajProblemu.SelectedItem;
            problemId = problemType.Id;
        }
    }
}