using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Dog : Mammal
    {
        public Dog(int years) : base(years)
        {
            Console.WriteLine("Dog constructor");
        }
    }
}
