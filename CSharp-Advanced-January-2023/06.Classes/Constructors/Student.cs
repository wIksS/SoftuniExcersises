using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Student
    {
        public Student()
        {
            Console.WriteLine("Object initialized!");
            Name = "Pesho";
            Age = 21;
            Grades = new List<double>();
        }

        public Student(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public List<double> Grades { get; set; }
    }
}
