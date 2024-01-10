using PAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Services
{
    internal class RequestService
    {
        public static List<Request> GetAllRequests()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var requests = context.Requests.ToList();
                    return requests;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static void AddRequest(Request request)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Requests.Add(request);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateRequest(Request request)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Requests.Update(request);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteRequest(Request requests)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Requests.Remove(requests);
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
