using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndInheritance
{
    internal class Person
    {
        public Person(string name)
        {
            Console.WriteLine("In Base Constructor");
            Name = name;
        }

        public string Name { get; set; }
    }
}
