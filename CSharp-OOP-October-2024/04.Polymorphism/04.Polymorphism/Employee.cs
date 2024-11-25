using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Polymorphism
{
    public abstract class Employee : IWorker
    {
        public void GetSalary()
        {
            Console.WriteLine("Salary day is the best day!");
        }

        public abstract void Work();

        public decimal Salary { get; set; }

        public List<DayOfWeek> Schedule { get; set; }
    }
}
