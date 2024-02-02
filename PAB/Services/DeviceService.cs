using Microsoft.EntityFrameworkCore;
using PAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace PAB.Services  
{
    internal class DeviceService
    {
        public static List<Device> GetAllDevices()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var devices = context.Devices.ToList();
                    return devices;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static Device GetDeviceById(int id)
        {
            var devices = GetAllDevices().FirstOrDefault(x => x.Id == id);
            return devices;
        }

        public static List<DeviceCategory> GetDeviceCategories()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var categories = context.DeviceCategories.ToList();
                    return categories;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static DeviceCategory GetDeviceCategoryById(int id)
        {
            var category = GetDeviceCategories().FirstOrDefault(x => x.Id == id);
            return category;
        }

        public static void AddDevice(Device device)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Devices.Add(device);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateDevice(Device device)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Devices.Update(device);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteDevice(Device device)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Devices.Remove(device);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<AssignedDevice> GetAssignedDevices()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var devices = context.AssignedDevices.Include(d => d.Device.Category).ToList();
                    return devices;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static void AssignDevice(AssignedDevice userDevice)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.AssignedDevices.Add(userDevice);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}