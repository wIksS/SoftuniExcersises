using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal("The Hippo", "Hippo", "male", true);
            Animal animal = new Animal("The Hippo", "Hippo", "myjki", true);

            Console.WriteLine(animal.IsHungry);
            Console.WriteLine(animal.Gender);
            Console.WriteLine(animal.Species);
            Console.WriteLine("Name " + animal.Name);
        }
    }
}
