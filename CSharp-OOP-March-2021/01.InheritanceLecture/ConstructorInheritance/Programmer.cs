using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInheritance
{
    class Programmer : Employee
    {
        public Programmer(string name, int salary, List<string> languages)
            : base(name, salary)
        {
            Languages = languages;
            Console.WriteLine("In Programmer");
        }

        public List<string> Languages { get; set; }

    }
}
