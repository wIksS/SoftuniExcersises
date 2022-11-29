using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public void GiveSalary()
        {
            foreach (var employee in employees)
            {
                employee.TakenSalary += employee.Salary;
            }
        }

        public void RaiseSalaryYearly(int percentage)
        {
            foreach (var employee in employees)
            {
                employee.Salary += employee.Salary * percentage / 100;
            }
        }
    }
}
