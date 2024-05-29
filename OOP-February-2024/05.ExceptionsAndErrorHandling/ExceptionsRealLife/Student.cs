using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsRealLife
{
    public class Student
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Students age cannot be less than 0");
                }

                age = value;
            }
        }

    }
}
