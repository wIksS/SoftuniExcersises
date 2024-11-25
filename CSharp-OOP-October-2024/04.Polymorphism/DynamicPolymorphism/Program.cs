
string input = Console.ReadLine();
Animal animal = null;

if (input == "dog")
{
    animal = new Dog() { Name = "Sharo" };
}
else
{
    animal = new Cat();
}

animal.Speak();
if (animal is Dog)
{
    ((Dog)animal).Speak();
}
else if(animal is Cat)
{
    ((Cat)animal).Speak();
}

class Animal
{
    public void Speak()
    {
        Console.WriteLine("hi");
    }
}

class Dog : Animal
{
    public string Name { get; set; }
    public void Speak()
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
    public void Speak()
    {
        Console.WriteLine("meow");
    }
}