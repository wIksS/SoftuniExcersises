using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Student
    {
        private int averageGrade;

        public Student()
        {
            Console.WriteLine("Empty constructor");
            averageGrade = 2;
        }

        public Student(string name)
            :this()
        {
            Console.WriteLine("1 param name constructor");

            this.Name = name;
        }

        public Student(string name, int age)
            : this(name)
        {
            Console.WriteLine("2 params name age constructor");

            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
