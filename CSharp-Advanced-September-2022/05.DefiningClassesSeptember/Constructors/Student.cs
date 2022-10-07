using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Student
    {
        private int averageGrade;

        public Student(string name, int age) : this(name)
        {
            Age = age;
        }

        public Student(string name)
        {
            Name = name;
            Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }
    }
}
