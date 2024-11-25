using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    class Student : Human
    {
        public Student(string name, int age, string university) : base(name, age)
        {
            Console.WriteLine("In Student Constructor");
            University = university;
        }

        public string University { get; set; }

        public double Score { get; set; }
    }
}
