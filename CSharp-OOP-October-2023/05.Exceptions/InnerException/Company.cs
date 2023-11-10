using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException
{
    internal class Company
    {
        private List<Employee> employees;

        public void AddEmployee(string name)
        {
            try
            {
                employees.Add(new Employee(name));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new ArgumentException("Could add an employee", ex);
            }
        }
    }
}
