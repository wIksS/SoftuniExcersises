using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal animal = new Cat("Koti", "negativni emocii");
            Console.WriteLine(animal.ExplainSelf());

            animal = new Dog("Kuchi", "pozitivni emocii i salam");
            Console.WriteLine(animal.ExplainSelf());
        }
    }
}
