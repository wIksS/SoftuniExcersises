//using System;

//namespace PolymorphismLecture
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Cat cat = null;
//            Dog dog = null;
//            Fish fish = null;

//            while (true)
//            {
//                string animalType = Console.ReadLine();

//                if (animalType == "Cat")
//                {
//                    cat = new Cat();
//                }
//                if (animalType == "Dog")
//                {
//                    dog = new Dog();
//                }
//                if (animalType == "Fish")
//                {
//                    fish = new Fish();
//                }

//                if (cat != null)
//                {
//                    cat.Talk();
//                }
//                if (dog != null)
//                {
//                    dog.Talk();
//                }
//                if (fish != null)
//                {
//                    fish.Talk();
//                }
//            }
//        }
//    }
//}
