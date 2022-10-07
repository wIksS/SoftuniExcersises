using System;
using System.Collections.Generic;
using System.Text;

namespace FIeldsAndProperties
{
    public class Student
    {
        private string name;

        //public string Username { get; set; }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Not enough characters");
                    return;
                }

                this.name = value;
            }
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is: {this.Name}");
        }
    }
}
