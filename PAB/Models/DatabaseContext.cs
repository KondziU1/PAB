using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAB.Models
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceCategory> DeviceCategories { get; set; }
        public DbSet<AssignedDevice> AssignedDevices { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ProblemType> ProblemTypes { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddUserSecrets<DatabaseContext>().Build();
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information).UseSqlServer(config["ConnectionString"]);
        }
    }
}