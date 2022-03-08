using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Employee : Object
    {
        public Employee(int salary, int experience)
        {
            Salary = salary;
            Experience = experience;
        }

        public decimal Salary { get; set; }

        public int WorkHours { get; set; }

        public int Experience { get; set; }

        public void Fire()
        {
            Console.WriteLine("Amaa az bachkah");
        }
    }
}
