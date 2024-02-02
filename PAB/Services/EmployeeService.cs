using PAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace PAB.Services
{
    internal class EmployeeService
    {
        public static List<Employee> GetAllEmployees()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var employees = context.Employees.ToList();
                    return employees;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static Employee GetEmployeeById(int id)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var employee = context.Employees.FirstOrDefault(e => e.Id == id);
                    return employee;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static List<Employee> GetEmployeesWithoutUser()
        {
            var users = UserService.GetAllUsers();
            var employeesWithoutUser = GetAllEmployees()
                .Where(e => !users.Any(u => u.EmployeeId == e.Id))
                .ToList();
            return employeesWithoutUser;
        }
    }
}
