using PAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Services
{
    internal static class NotificationService
    {
        public static List<Notification> GetStaffNotifications()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var notifications = context.Notifications.Where(u => u.UserId == null).ToList();
                    return notifications;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static List<Notification> GetUserNotifications(User user)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var notifications = context.Notifications.AsQueryable();

                    if (user.Role == "Admin")
                    {
                        notifications = notifications.Where(u => u.UserId == null);
                    }
                    else
                    {
                        notifications = notifications.Where(u => u.UserId == user.Id);
                    }

                    return notifications.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        public static Notification GetNotificationByID(int id)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var notification = context.Notifications.Where(n => n.Id == id).FirstOrDefault();
                    return notification;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void AddNotification(Notification notification)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Notifications.Add(notification);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteNotification(Notification notification)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Notifications.Remove(notification);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SendNotificationToUser(string message, User user)
        {
            var notification = new Notification(message, DateTime.Now, user.Id);

            AddNotification(notification);
        }

        public static void SendNotificationToStaff(string message)
        {
            var notification = new Notification(message, DateTime.Now, null);

            AddNotification(notification);
        }

    }
}