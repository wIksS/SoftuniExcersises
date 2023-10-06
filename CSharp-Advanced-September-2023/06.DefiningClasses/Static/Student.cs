using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Student
    {
        public static string staticUniversity = "SoftUni";
        public string instanceUniversity = "SoftUni";

        public string Name { get; set; }

        public void PrintStudent()
        {
            Console.WriteLine(Name);
        }

        public static void StaticPrintStudent()
        {
            Console.WriteLine("Static member");
            Console.WriteLine(Student.staticUniversity);
        }
    }
}
