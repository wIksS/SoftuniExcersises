using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySingleResponsbility
{
    public class EmployeeReportService
    {
        public void PrintReport(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} has salary {employee.Salary}. Years In Company: {employee.YearsInCompany}");
            }
        }
    }
}
