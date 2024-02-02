using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Models
{
    public class Device
    {
        public Device()
        { }

        public Device(string name, string condition, int quantity, int category_ID)
        {
            Name = name;
            Condition = condition;
            Quantity = quantity;
            CategoryId = category_ID;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }

        public DeviceCategory Category { get; set; }
    }
}