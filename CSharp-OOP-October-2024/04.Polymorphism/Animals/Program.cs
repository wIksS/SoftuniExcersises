
//Animal dog = new Dog();

//Console.WriteLine(dog is Dog);
//Console.WriteLine(dog is Animal);
//Console.WriteLine(dog is Cat);
//Console.WriteLine(dog is Object);



string input = Console.ReadLine();
Animal animal = null;

if (input == "dog")
{
    animal = new Dog() { Name="Sharo"};
}
else
{
    animal = new Cat();
}

Dog dogCastedAs = animal as Dog;
if (dogCastedAs != null)
{
    dogCastedAs.AskForFood();
}

animal.Speak();

if (animal is Dog)
{
    ((Dog)animal).AskForFood();
}

if (animal is Dog dog)
{
    dog.AskForFood();
}
Speak(animal);

void Speak(Animal animal)
{
    animal.Speak();

}


class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("hi");
    }
}

class Dog : Animal
{
    public string Name { get; set; }
    public override void Speak()
    {
        Console.WriteLine("Bark");
    }

    public void AskForFood()
    {
        Console.WriteLine("Give me food!");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("meow");
    }
}