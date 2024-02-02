using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Models
{
    internal class Notification
    {
        public Notification() { }
        public Notification(string message, DateTime dateCreated, int? user_id)
        {
            Message = message;
            DateCreated = dateCreated;
            UserId = user_id;
        }

        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }
        public int? UserId { get; set; }

        public User user { get; set; }
    }
}