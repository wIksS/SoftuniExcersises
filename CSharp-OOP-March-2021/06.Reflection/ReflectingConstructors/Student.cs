using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectingConstructors
{
    class Student
    {
        public Student()
        {

        }

        public Student(string name, int x)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
