using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Cat cat= new Cat("Peter", "Whiskas");
            Animal animalCat = cat;

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(animalCat.ExplainSelf());
        }
    }
}
