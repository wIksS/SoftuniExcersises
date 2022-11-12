using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual
{
    public class Employee
    {
        public decimal Salary { get; set; }

        public string Name { get; set; }

        public virtual void Work()
        {
            Console.WriteLine($"Gore dolu ba4kam, gledam i da si po4ivam");
        }

        public override string ToString()
        {
            return $"Nashiq si tostring";
        }
    }
}
