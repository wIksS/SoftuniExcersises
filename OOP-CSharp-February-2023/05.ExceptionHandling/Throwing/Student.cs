using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throwing
{
    public class Student
    {

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Age is not correct");
                }
                age = value;
            }
        }

    }
}
