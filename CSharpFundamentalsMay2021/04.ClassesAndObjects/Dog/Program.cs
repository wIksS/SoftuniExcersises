using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog.Bark();
            Dog.AverageLife = 20;

            Dog dog = new Dog("Sharo", "Pitbull", 3);
            
            Dog dog2 = new Dog("Djoni", "Retrivyr", 4);

            Dog dog3 = new Dog();

            dog.SayHi();
            dog2.SayHi();
            dog3.SayHi();
        }
    }
}
