using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndInheritance
{
    internal class HighschoolStudent : Student
    {
        public HighschoolStudent(string name, int grade, string badRemarks) : base(name)
        {
            Console.WriteLine("In child of a child");
            Grade= grade;   
            BadRemarks = badRemarks;
        }

        public string BadRemarks { get; set; }
    }
}
