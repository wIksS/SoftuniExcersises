
// polymorphism
//IAnimal animal = new Fish();

//animal.Eat();
namespace ns
{

    class Program
    {
        static void Main()
        {
            AnimalEat(new Dog());
            AnimalEat(new Fish());
        }

        static void AnimalEat(Dog animal)
        {
            Console.WriteLine("Feeding the animal");
            animal.Eat();
        }
        static void AnimalEat(Fish animal)
        {
            Console.WriteLine("Feeding the animal");
            animal.Eat();
        }

        static void AnimalEat(int animal)
        {
            Console.WriteLine("Feeding the animal");
            //animal.Eat();
        }

        static void AnimalEat(Cat animal)
        {
            Console.WriteLine("Feeding the animal");
            animal.Eat();
        }

        interface IAnimal
        {
            void Eat();
        }


        class Dog : IAnimal
        {
            public void Eat()
            {
                Console.WriteLine("Pravi pakosti i capa navsqkyde");
            }
        }

        class Fish : IAnimal
        {
            public void Eat()
            {
                Console.WriteLine("Fish is eating");
            }
        }

        class Cat : IAnimal
        {
            public void Eat()
            {
                Console.WriteLine("Cat is eating");
            }
        }
    }
}

