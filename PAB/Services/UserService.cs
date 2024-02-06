using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PAB.Models;
using Microsoft.EntityFrameworkCore;
using iText.Kernel.Pdf;
using System.Diagnostics;
using iText.Kernel.Colors;
using iText.Layout.Properties;
using iText.IO.Font;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

namespace PAB.Services
{
    internal static class UserService
    {
        public static List<User> GetAllUsers()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var users = context.Users.Include(e => e.Employee).ToList();
                    return users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static User GetUserById(int id)
        {
            var user = GetAllUsers().FirstOrDefault(x => x.Id == id);
            return user;
        }

        public static string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        public static bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }

        public static User Login(string login, string password)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var user = context.Users.Include(e => e.Employee).FirstOrDefault(u => u.Login == login);

                    if (user != null && UserService.VerifyPassword(password, user.Password))
                    {
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void AddUser(User user)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateUser(User user)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Users.Update(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteUser(User user)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool IsUserExists(User user)
        {
            var existingUser = GetAllUsers().FirstOrDefault(x => x.Login == user.Login);

            if (existingUser != null)
            {
                return true;
            }
            else
                return false;
        }
        public static List<AssignedDevice> GetUserDevices(User user)
        {
            var devices = DeviceService.GetAssignedDevices().Where(u => u.UserId == user.Id).ToList();
            return devices;
        }

        public static void GenerateUsersPDF()
        {
            var users = GetAllUsers();
            string currentDateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PAB_Reports");
            string outputPath = Path.Combine(folderPath, $"Users_{currentDateTime}.pdf");

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


                    var table = new Table(5, false)
                        .UseAllAvailableWidth()
                        .SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell("Login").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Full Name").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Role").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Room").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Manager").SetFontColor(black).SetBold();

                    foreach (var user in users)
                    {
                        var userLogin = user.Login ?? "-";
                        var userFullName = user.Employee?.FullName ?? "-";
                        var userRole = user.Role ?? "-";
                        var userRoom = user.Employee?.RoomNumber.ToString() ?? "-";
                        var managerFullName = user.ManagerId.HasValue ? UserService.GetUserById(user.ManagerId.Value)?.Employee?.FullName : "-";

                        table.AddCell(userLogin);
                        table.AddCell(userFullName);
                        table.AddCell(userRole);
                        table.AddCell(userRoom);
                        table.AddCell(managerFullName);
                    }

                    document.Add(table);
                }
            }

            Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
        }

    }
}