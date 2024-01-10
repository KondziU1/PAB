﻿using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PAB.Models;

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
                    var users = context.Users.ToList();
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
                    var user = context.Users.FirstOrDefault(u => u.Login == login);

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
        public static List<Device> GetUserDevices(User user)
        {
            var devices = DeviceService.GetAssignedDevices().Where(u => u.User_ID == user.Id).Select(d => DeviceService.GetDeviceById(d.Device_ID)).ToList();
            return devices;
        }
    }
}