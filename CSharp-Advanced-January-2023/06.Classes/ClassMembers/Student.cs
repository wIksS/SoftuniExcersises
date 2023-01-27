using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public double AverageGrade { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {this.FirstName}{this.LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"AverageGrade: {AverageGrade}");
        }

    }
}
