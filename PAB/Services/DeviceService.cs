using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.EntityFrameworkCore;
using PAB.Models;
using System.Diagnostics;

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
                    var devices = context.AssignedDevices.Include(d => d.Device.Category).Include(u => u.User.Employee).ToList();
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

        public static void GenerateAssignedDevicesReport()
        {
            List<AssignedDevice> assignedDevices = GetAssignedDevices();
            string currentDateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PAB_Reports");
            string outputPath = Path.Combine(folderPath, $"AssignedDevicesReport_{currentDateTime}.pdf");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (var writer = new PdfWriter(outputPath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA, PdfEncodings.CP1250);
                    var black = new DeviceRgb(0, 0, 0);

                    var document = new Document(pdf);
                    document.SetFont(font).SetFontSize(15);
                    document.SetTextAlignment(TextAlignment.CENTER);

                    var table = new Table(4, false)
                        .UseAllAvailableWidth()
                        .SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell("Login").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Full Name").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Role").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Device").SetFontColor(black).SetBold();

                    foreach (var assignedDevice in assignedDevices)
                    {
                        var userLogin = assignedDevice.User?.Login ?? "-";
                        var userFullName = assignedDevice.User?.Employee?.FullName ?? "-";    
                        var userRole = assignedDevice.User?.Role ?? "-";
                        var deviceName = assignedDevice.Device?.Name ?? "-";

                        table.AddCell(userLogin);
                        table.AddCell(userFullName);
                        table.AddCell(userRole);
                        table.AddCell(deviceName);
                    }

                    document.Add(table);
                }
            }

            Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
        }

    }
}