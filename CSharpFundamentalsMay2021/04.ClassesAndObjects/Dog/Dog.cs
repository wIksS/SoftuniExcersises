using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Dog
    {
        public Dog()
        {
            Name = "Sharo";
            Age = 4;
        }

        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public static int AverageLife { get; set; }

        public void SayHi()
        {
            Console.WriteLine("Hey from dog!");
            Console.WriteLine($"My name is: {Name} Breed: {Breed}");
            Console.WriteLine("Bye!");
        }

        public static void Bark()
        {
            Console.WriteLine("Bark");
        }
    }
}
