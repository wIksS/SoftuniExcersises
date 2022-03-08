using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual
{
    class Elephant : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Elephant eating");
            Food = 0;
        }
    }
}
