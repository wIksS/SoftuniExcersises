using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Company
    {
        public List<Department> Departments { get; set; }

        public void RaiseSalary(int percentage)
        {
            foreach (var department in Departments)
            {
                department.RaiseSalary(percentage);
            }
        }
    }
}
