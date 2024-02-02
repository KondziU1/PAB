﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Models
{
    public class AssignedDevice
    {
        public AssignedDevice() { }
        public AssignedDevice(int deviceId, int userId)
        {
            DeviceId = deviceId;
            UserId = userId;
        }

        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int UserId { get; set; }

        public Device Device { get; set; }
        public User User { get; set; }
    }

}