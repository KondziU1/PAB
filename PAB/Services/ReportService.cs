using iText.IO.Font.Constants;
using iText.IO.Font;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Properties;
using Microsoft.EntityFrameworkCore;
using PAB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using iText.Layout;
using iText.Layout.Element;

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
                    var reports = context.Reports.Include(r => r.User.Employee).Include(r => r.Device).Include(r => r.ProblemType).ToList();
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
        public static void GenerateReportsPDF()
        {
            var reports = GetAllReports();
            string currentDateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PAB_Reports");
            string outputPath = Path.Combine(folderPath, $"Reports_{currentDateTime}.pdf");

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

                    table.AddHeaderCell("Report Number").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Employee").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Device").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Status").SetFontColor(black).SetBold();

                    foreach (var report in reports)
                    {
                        var reportNumber =  report.Id.ToString() ?? "-";
                        var userFullName = report.User?.Employee?.FullName ?? "-";
                        var device = report.Device?.Name ?? "-";
                        var status = report.Status ?? "-";

                        table.AddCell(reportNumber);
                        table.AddCell(userFullName);
                        table.AddCell(device);
                        table.AddCell(status);
                    }

                    document.Add(table);
                }
            }

            Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
        }
    }

}
