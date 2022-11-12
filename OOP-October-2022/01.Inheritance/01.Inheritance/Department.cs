using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Inheritance
{
    internal class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }
        public List<Employee> Employees { get; set; }

        public decimal BiggestSalary()
        {
            return Employees.Max(x => x.Salary);
        }
    }
}
