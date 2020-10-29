using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("In the person constructor");
        }

        protected bool Gender { get {return true; }}

        public string Name { get; set; }

        public int Age { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Sleeping!!!");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
