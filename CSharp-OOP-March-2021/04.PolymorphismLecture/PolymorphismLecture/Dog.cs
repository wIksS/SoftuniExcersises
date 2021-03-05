using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismLecture
{
    class Dog : IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Bau");
        }
    }
}
