using PAB.Models;
using PAB.Services;
using System.Runtime.Versioning;

namespace PAB.Forms.UserManagement
{
    public partial class RequestsForm : Form
    {
        private User user;

        public RequestsForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        internal void LoadData()
        {
            var requests = RequestService.GetAllRequests().Where(x => (x.Status == "Wysłany" || x.Status == "Otworzony") && x.ManagerId == user.Id).ToList();
            dataGridView1.DataSource = requests;
        }

        private Request GetSelectedRequest()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                Request selectedRequest = (Request)selectedRow.DataBoundItem;

                return selectedRequest;
            }
            return null;
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void Notify(Request request)
        {
            string message = $"Wniosek o urządzenie: {request.Device.Name} został {request.Status}";
            NotificationService.SendNotificationToUser(message, request.User);
        }

        private void btnShowRequest_Click(object sender, EventArgs e)
        {
            var request = GetSelectedRequest();

            if (request != null)
            {
                if (request.Status == "Wysłany")
                {
                    request.Status = "Otworzony";
                    RequestService.UpdateRequest(request);

                    Notify(request);
                }

                var frm = new RequestDetailsForm(request, this);
                frm.ShowDialog();
            }
        }
    }
}