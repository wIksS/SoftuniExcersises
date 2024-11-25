using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class Human
    {
        public Human(string name, int age)
        {
            Console.WriteLine("In human constructor");
            Name = name;
            Age = age;
        }

        public Human()
        {

        }

        public string Name { get; set; }

        public int Age { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Human sleeping!");
        }
    }
}
