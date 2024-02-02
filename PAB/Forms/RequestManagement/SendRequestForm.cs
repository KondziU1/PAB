using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class SendRequestForm : Form
    {
        private User user;
        private Device device;

        public SendRequestForm(User user, Device device)
        {
            this.user = user;
            this.device = device;
            InitializeComponent();
        }

        private void Notify(Request request)
        {
            var employee = user.Employee;
            if (employee == null) return;

            string message = $"Nowy wniosek od {employee.FullName}({user.Login})";

            if (user.ManagerId == null)
            {
                return;
            }

            var manager = UserService.GetUserById((int)user.ManagerId);
            if (manager != null)
            {
                NotificationService.SendNotificationToUser(message, manager);
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            var reason = rtxtReason.Text;
            var request = new Request(user.Id, device.Id, reason, user.ManagerId, "Wysłany");
            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Wszystkie pola są wymagane!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Czy na pewno chcesz wysłać wniosek?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                RequestService.AddRequest(request);
                Notify(request);
                this.Close();
            }
            else
                return;
        }

        private void SendRequestForm_Load(object sender, EventArgs e)
        {
            if (device != null)
            {
                txtDevice.Text = device.Name;
            }
        }
    }
}