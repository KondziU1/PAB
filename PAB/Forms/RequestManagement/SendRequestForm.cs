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

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            var reason = rtxtReason.Text;
            var request = new Request(user.Id, device.Id, reason, "Wysłany");
            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Wszystkie pola są wymagane!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Czy na pewno chcesz wysłać wniosek?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                RequestService.AddRequest(request);
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