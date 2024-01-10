﻿using PAB.Forms.UserManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class RequestDetailsForm : Form
    {
        Request request;
        Form parentForm;
        public RequestDetailsForm(Request request, Form parentForm)
        {
            this.parentForm = parentForm;
            this.request = request;
            InitializeComponent();
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            var user = UserService.GetUserById(request.User_ID);
            var device = DeviceService.GetDeviceById(request.Device_ID);

            txtApplicant.Text = user.Login;
            txtDevice.Text = device.Name;
            rtxtReason.Text = request.Reason;
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
                this.Close();
            }
            else
                return;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ChangeRequestStatus("Zaakceptowany");
            if(request.Status == "Zaakceptowany")
            {
                var userDevice = new AssignedDevice(request.Device_ID, request.User_ID);
                DeviceService.AssignDevice(userDevice);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ChangeRequestStatus("Odrzucony");
        }
    }
}