using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Student
    {
        private static readonly  int courses = 5;
        public static int NumberOfStudents { get; set; }

        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine(Name);
        }

        public static void PrintUniversity()
        {
            Console.WriteLine("Softuni");
            Console.WriteLine(NumberOfStudents);
        }
    }
}
