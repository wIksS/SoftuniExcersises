using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Inheritance
{
    public class Programmer : Employee
    {
        public Programmer(string name) : base(55)
        {
            Console.WriteLine($"In Programmer constructor with name {name}");
        }

        public void CreateBugs()
        {
            Console.WriteLine($"I am {Name} and only creating bugs all day");
        }
    }
}
