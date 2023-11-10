using CompanySingleResponsbility.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySingleResponsbility
{
    public class EmployeeDataService
    {
        public void AddTenure(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                employee.YearsInCompany++;
            }
        }

    }
}
