using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class Employee : Person
    {
        public List<string> Benefits { get; set; }

        public bool IsNationalIdValid()
        {
            return NationalId.Length == 8;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{Name}, {Age}, {Address}");
        }
    }
}
