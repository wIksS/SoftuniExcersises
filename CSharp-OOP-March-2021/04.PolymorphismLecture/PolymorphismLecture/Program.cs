using System;

namespace PolymorphismLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;

            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Dog")
                {
                    animal = new Dog();
                }
                if (animalType == "Cat")
                {
                    animal = new Cat();
                }
                if (animalType == "Fish")
                {
                    animal = new Fish();
                }

                var fish = animal as Fish;
                if (fish != null)
                {
                    fish.Jump();
                    Console.WriteLine("As is super cool");
                }

                if (animal is Fish)
                {
                    ((Fish)animal).Jump();
                }

                if (animal.GetType() == typeof(Fish))
                {
                    Console.WriteLine("Riba");
                }


                animal.Talk();
            }
        }
    }
}
