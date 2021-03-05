using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismLecture
{
    class Person
    {
        public IAnimal Animal { get; set; }

        public void Eat()
        {
            Console.WriteLine("Person is eating");

            Animal.Talk();
        }
    }
}
