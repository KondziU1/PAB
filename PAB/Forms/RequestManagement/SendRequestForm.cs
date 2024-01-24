using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAB.Models;
using PAB.Services;
using System.Windows.Media.Animation;

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
            var user = UserService.GetUserById(request.User_ID);

            if (user.Employee_ID == null)
            {
                return;
            }

            var employee = EmployeeService.GetEmployeeById((int)user.Employee_ID);

            string message = $"Nowy wniosek od {employee.FullName}({user.Login})";

            if(user.Manager_ID == null)
            {
                return;
            }

            var manager = UserService.GetUserById((int)user.Manager_ID);

            NotificationService.SendNotificationToUser(message, manager);
        }
        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            var reason = rtxtReason.Text;
            var request = new Request(user.Id, device.Id, reason, user.Manager_ID, "Wysłany");
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
            txtDevice.Text = device.Name;
        }
    }
}