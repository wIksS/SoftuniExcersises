using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsAndProperties
{
    class Student
    {
        // private, protected, internal, public
        private int score = -1;
        private string name = "Anonymous";
        private List<Course> courses = new List<Course>();

        public void PrintStudent()
        {
            PrintStudentName();
            Console.WriteLine(this.score);
            Console.WriteLine(this.courses.Count);
        }

        // access modifiers
        private void PrintStudentName()
        {
            Console.WriteLine(this.name);
        }
    }
}
