using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person (int age) : this()
        {
            Age = age;
        }

        public Person (string name, int age) : this(age)
        {
            Name = name;
        }

        public string Name
        {
            get => this.name;
            set => name = value;
        }

        public int Age
        {
            get => this.age;
            set => age = value;
        }
    }
}