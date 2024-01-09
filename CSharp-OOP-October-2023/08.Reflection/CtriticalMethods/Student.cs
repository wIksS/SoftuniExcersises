using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtriticalMethods
{
    [Critical]
    class Student
    {
        [Critical(Severity = Severity.Critical)]

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Score = 2;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Score { get; set; }


        [Critical(Severity = Severity.Moderate, Message = "This method is important because I say so")]
        public void Print()
        {

        }

    }
}
