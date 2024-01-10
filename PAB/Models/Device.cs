using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
        public int Quantity { get; set; }
        public int Category_ID { get; set; }

        public Device(string name, string condition, int quantity, int category_ID)
        {
            Name = name;
            Condition = condition;
            Quantity = quantity;
            Category_ID = category_ID;
        }
    }
}
