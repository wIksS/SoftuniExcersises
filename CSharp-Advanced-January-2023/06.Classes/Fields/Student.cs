using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Student
    {
        private string firstName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public void PrintStudent()
        {
            Console.WriteLine(firstName);
        }
    }
}
