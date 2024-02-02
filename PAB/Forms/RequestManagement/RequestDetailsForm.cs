using Microsoft.VisualBasic.ApplicationServices;
using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;
using System.Windows.Forms;

namespace PAB.Forms.UserManagement
{
    public partial class RequestDetailsForm : Form
    {
        private Request request;
        private Form parentForm;

        public RequestDetailsForm(Request request, Form parentForm)
        {
            this.parentForm = parentForm;
            this.request = request;
            InitializeComponent();
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            txtApplicant.Text = request.User.Login;
            txtDevice.Text = request.Device.Name;
            rtxtReason.Text = request.Reason;
        }

        private void Notify()
        {
            string message = $"Wniosek o urządzenie: {request.Device.Name} został {request.Status}";
            NotificationService.SendNotificationToUser(message, request.User);
        }

        private void ChangeRequestStatus(string status)
        {
            var message = status == "Zaakceptowany" ? $"Czy na pewno chcesz zaakceptowac wniosek o id: {request.Id}?" : $"Czy na pewno chcesz odrzucić wniosek o id: {request.Id}?";
            var result = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                request.Status = status;
                RequestService.UpdateRequest(request);
                var frm = (RequestsForm)parentForm;
                frm.LoadData();
                Notify();
                this.Close();
            }
            else
                return;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (request.Device.Quantity == 0)
            {
                var message = $"Urządzenie: {request.Device.Name} jest aktualnie niedostępne";
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var user = UserService.GetUserById(request.UserId);
                NotificationService.SendNotificationToUser(message, user);
                RequestService.DeleteRequest(request);
                var frm = (RequestsForm)parentForm;
                frm.LoadData();
                this.Close();
                return;
            }

            ChangeRequestStatus("Zaakceptowany");
            if (request.Status == "Zaakceptowany")
            {
                var userDevice = new AssignedDevice(request.DeviceId, request.UserId);
                request.Device.Quantity -= 1;
                DeviceService.UpdateDevice(request.Device);
                DeviceService.AssignDevice(userDevice);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ChangeRequestStatus("Odrzucony");
        }
    }
}