using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class Worker : Human
    {
        public string Job { get; set; }

        public decimal Salary { get; set; }

        public void Work()
        {
            Console.WriteLine("Worker working!");
        }
    }
}
