using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Polymorphism
{
    public class Programmer : IAnimal, IPerson
    {
        public Programmer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name}: I am eating!");
        }

        public void Work()
        {
            Console.WriteLine($"{Name}: Skatavam!");
        }
    }
}
