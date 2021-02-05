using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    class Person
    {
        private string name;
        private string lastName = "Peshov";
        private int age;

        public string FullName
        {
            get { return name + " " + lastName; }
        }

        public string Name
        {
            get
            {
                Console.WriteLine("Getting the name: " + name);
                return name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    Console.WriteLine("Invalid data try again!!!");
                }
                else
                {
                    name = value;
                }
            }
        }

        public int Salary { get; set; }
    }
}
