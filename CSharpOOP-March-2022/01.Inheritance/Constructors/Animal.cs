using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }

        public Animal(int years)
        {
            this.EatAmount = 64;
            Console.WriteLine("Animal constructor with years " + years);
        }

        public int EatAmount { get; set; }

        public void Eat()
        {
            Console.WriteLine("I am Eating");
        }
    }
}
