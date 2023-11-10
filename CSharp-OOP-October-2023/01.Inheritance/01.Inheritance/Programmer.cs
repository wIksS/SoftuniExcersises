using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class Programmer : Employee
    {
        public List<string> ProgrammingLanguages { get; set; }

        public float YearsOfExperience { get; set; }

        public virtual void Program()
        {
 
            Console.WriteLine("Ne znam kakvo pravq :(");
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} C#");
        }
    }
}
