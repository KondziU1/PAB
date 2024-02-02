using PAB.Models;
using PAB.Services;

namespace PAB.Forms.UserManagement
{
    public partial class HomeForm : Form
    {
        private User user;

        public HomeForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            var notifications = NotificationService.GetUserNotifications(user);

            if (notifications != null)
            {
                notifications.ForEach(n => dataGridView1.Rows.Add(n.Id, n.Message, "X"));
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                var id = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                var notification = NotificationService.GetNotificationByID(id);
                if (notification != null)
                {
                    NotificationService.DeleteNotification(notification);
                    LoadData();
                }
            }
        }
    }
}