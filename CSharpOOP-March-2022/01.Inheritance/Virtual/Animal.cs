using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual
{
    class Animal
    {
        public int Food { get; set; }

        public Animal()
        {
            Food = 100;
        }

        public virtual void Eat()
        {
            Console.WriteLine("Animal Eating");
            Food -= 25;
        }
    }
}
