using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private string name;

        public string Name
        {
            get
            {
                Console.WriteLine("Getter for name was called!");
                return name;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Value should be more than 3");
                    return;
                }
                
                Console.WriteLine("Setter for name was called!");
                this.name = value;
            }
        }

        public void Print()
        {
            Console.WriteLine();
        }
    }
}
