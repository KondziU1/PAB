using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Models
{
    public class User
    {
        public User(string login, string password, string role)
        {
            Login = login;
            Password = password;
            Role = role;
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int? Manager_ID { get; set; }
        public int? Employee_ID { get; set; } 
    }
}
