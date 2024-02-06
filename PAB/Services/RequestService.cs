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
using iText.Layout;
using iText.Layout.Element;

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
                    var requests = context.Requests.Include(r => r.Device).Include(r=> r.User.Employee).ToList();

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
        public static void GenerateRequestsPDF()
        {
            var requests = GetAllRequests();
            string currentDateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PAB_Reports");
            string outputPath = Path.Combine(folderPath, $"Requests_{currentDateTime}.pdf");

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

                    table.AddHeaderCell("Request Number").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Employee").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Device").SetFontColor(black).SetBold();
                    table.AddHeaderCell("Status").SetFontColor(black).SetBold();

                    foreach (var request in requests)
                    {
                        var reportNumber = request.Id.ToString() ?? "-";
                        var userFullName = request.User?.Employee?.FullName ?? "-";
                        var device = request.Device?.Name ?? "-";
                        var status = request.Status ?? "-";

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
