using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismLecture
{
    class Fish : IAnimal
    {
        public  void Talk()
        {
            Console.WriteLine("Bylbuk bylbuk");
        }

        public void Jump()
        {
            Console.WriteLine("Jumping");
        }
    }
}
