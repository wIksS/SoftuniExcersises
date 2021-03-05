using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismLecture
{
    class Cat : IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Meow");
        }
    }
}
