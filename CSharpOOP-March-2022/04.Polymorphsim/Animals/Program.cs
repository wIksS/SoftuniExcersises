using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal animal;
            animal  = new Cat("Peter", "Whiskas");

            Console.WriteLine(animal.ExplainSelf());

            animal = new Dog("George", "Meat");

            Console.WriteLine(animal.ExplainSelf());

        }
    }
}
