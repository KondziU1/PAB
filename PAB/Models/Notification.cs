using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Models
{
    internal class Notification
    {
        public Notification(string message, DateTime dateCreated, bool isRead, int user_id)
        {
            Message = message;
            DateCreated = dateCreated;
            IsRead = isRead;
            User_id = user_id;
        }

        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsRead { get; set; }
        public int User_id { get; set; }
    }
}