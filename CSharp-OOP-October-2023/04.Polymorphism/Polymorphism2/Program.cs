Dog dog = new Dog();

IAnimal animal;
if (Console.ReadLine() == "dog")
{
    animal = new Dog();
}
else
{
    animal = new Cat();
}

// ctr + k + d
animal.Eat();

if (Console.ReadLine() == "dog")
{
    AnimalEat(new Dog());
}
else
{
    AnimalEat(new Cat());
}

static void AnimalEat(IAnimal animal)
{
    Console.WriteLine("Feeding the animal");
    animal.Eat();
}


interface IAnimal
{
    void Eat();
}


public class Dog : IAnimal
{
    public void Bark()
    {
        Console.WriteLine("Bark");
    }
    public void Eat()
    {
        Console.WriteLine("Pravi pakosti i capa navsqkyde");
    }

    public class InnerClass
    {
        public int MyProperty { get; set; }
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

