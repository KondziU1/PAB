using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Models
{
    public class Request
    {
        public Request(int user_ID, int device_ID, string reason, string status)
        {
            User_ID = user_ID;
            Device_ID = device_ID;
            Reason = reason;
            Status = status;
        }

        public int Id { get; set; }
        public int User_ID { get; set; }
        public int Device_ID { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    }
}
