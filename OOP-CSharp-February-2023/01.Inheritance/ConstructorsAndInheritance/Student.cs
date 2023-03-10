using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndInheritance
{
    internal class Student : Person
    {
        public Student(string name, int grade) : base(name)
        {
            Console.WriteLine("In Child Constructor");
            Grade = grade;
           
        }

        public Student(string name) : base(name)
        {
            Console.WriteLine("In child with name only constructor");
        }

        public int Grade { get; set; }

        public void SayHi()
        {
            Console.WriteLine(Name);
            Console.WriteLine(this.Name);
            Console.WriteLine(base.Name);

            base.Name = "Hey";
        }
    }
}
