using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Models
{
    internal class AssignedDevice
    {
        public AssignedDevice(int device_ID, int user_ID)
        {
            Device_ID = device_ID;
            User_ID = user_ID;
        }

        public int Id { get; set; }
        public int Device_ID { get; set; }
        public int User_ID { get; set; }

    }
}