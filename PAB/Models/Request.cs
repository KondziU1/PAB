using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Models
{
    public class Request
    {
        public Request() { }
        public Request(int user_ID, int device_ID, string reason, int? manager_id, string status)
        {
            UserId = user_ID;
            DeviceId = device_ID;
            Reason = reason;
            ManagerId = manager_id;
            Status = status;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int DeviceId { get; set; }
        public string Reason { get; set; }
        public int? ManagerId { get; set; }
        public string Status { get; set; }

        public User User { get; set; }
        public Device Device { get; set; }
    }
}