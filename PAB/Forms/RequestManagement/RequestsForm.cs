using PAB.Models;
using PAB.Services;
using System.Runtime.Versioning;

namespace PAB.Forms.UserManagement
{
    public partial class RequestsForm : Form
    {
        private User user;
        private List<Request> requests;

        public RequestsForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        internal void LoadData()
        {
            requests = RequestService.GetAllRequests();
            if (user.Role == "Manager")
            {
                requests = requests.Where(x => (x.Status == "Wysłany" || x.Status == "Otworzony") && x.ManagerId == user.Id).ToList();
            }
            else if (user.Role == "Basic")
            {
                requests = requests.Where(x => x.UserId == user.Id).ToList();
            }

            MapRequestData(requests);
        }
        private void MapRequestData(List<Request> requests)
        {
            var requestData = requests.Select(r => new { Request = r, Number = r.Id, Employee = r.User?.Employee?.FullName, Device = r.Device?.Name, Status = r.Status }).ToList();

            dataGridView1.DataSource = requestData;
            dataGridView1.Columns[0].Visible = false;
        }
        private Request GetSelectedRequest()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                var selectedItem = selectedRow.DataBoundItem as dynamic;
                var request = selectedItem.Request as Request;

                return request;
            }
            return null;
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            LoadData();

            if (user.Role != "Admin")
                btnGeneratePDF.Visible = false;

            if (user.Role == "Basic")
            {
                btnShowRequest.Visible = false;
                dataGridView1.Columns[2].Visible = false;
            }

            dataGridView1.Columns[0].Visible = false;
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
        private void FilterData(string searchText)
        {
            var filteredData = requests.Where(x => x.Id.ToString().Contains(searchText)).ToList();
            MapRequestData(filteredData);

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
                RequestService.GenerateRequestsPDF();
            }
        }
    }
}