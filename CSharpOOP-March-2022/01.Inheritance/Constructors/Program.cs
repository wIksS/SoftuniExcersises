using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(4);

            Mammal mammal = new Mammal(4);
            mammal.Eat();
            mammal.MammalEat(5);
        }
    }
}
