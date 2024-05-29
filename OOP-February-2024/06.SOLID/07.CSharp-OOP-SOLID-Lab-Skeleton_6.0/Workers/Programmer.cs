using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal class Programmer : IEmployee
    {
        public int Salary { get => 100; set { } }

        public void GiveVouchers()
        {
            Console.WriteLine();
        }

        public void PaySalary()
        {
            Console.WriteLine();
        }

        public void Work()
        {
            Console.WriteLine("Nqma");
        }
    }
}
