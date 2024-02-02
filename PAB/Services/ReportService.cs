using Microsoft.EntityFrameworkCore;
using PAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PAB.Services
{
    internal class ReportService
    {
        public static List<Report> GetAllReports()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var reports = context.Reports.Include(r => r.User).Include(r => r.Device).Include(r => r.ProblemType).ToList();
                    return reports;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static void AddReport(Report report)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Reports.Add(report);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateReport(Report report)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Reports.Update(report);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteReport(Report report)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Reports.Remove(report);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<ProblemType> GetProblemTypes()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var problems = context.ProblemTypes.ToList();
                    return problems;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static ProblemType GetProblemTypeById(int id)
        {
            var problem = GetProblemTypes().Where(p => p.Id == id).FirstOrDefault();
            return problem;
        }
        public static void AcceptReport()
        {

        }

        public static void CancelReport() 
        {

        }
    }

}
