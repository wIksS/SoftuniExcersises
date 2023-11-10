using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class Manager : Employee
    {
        public List<Employee> Employees{ get; set; }
    }
}
