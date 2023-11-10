
IAnimal animal = new Dog();

int x = 10;
const int y = 15;
if (x is y)
{
    Console.WriteLine("");
}

if (animal is Dog)
{
    Console.WriteLine("animal is dog");
}

if (animal is Fish)
{
    Console.WriteLine("Animal is fish");
}

if (animal is IAnimal && animal is Object)
{
    Console.WriteLine("IAnimal and Object");
}

AnimalEat(new Dog());
AnimalEat(new Fish());

void AnimalEat(IAnimal animal)
{
    animal.Eat();

    if (animal is Dog)
    {
        ((Dog)animal).Bark();
        //Dog dog = (animal as Dog);
        (animal as Dog).Bark();
        //dog.Bark();
    }
    else if ( animal is Fish)
    {
        ((Fish)animal).Swim();
    }

    if (animal is Dog dog)
    {
        dog.Bark();
    }
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

    public void Bark()
    {
        Console.WriteLine("Barking");
    }
}

class Fish : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Fish is eating");
    }

    internal void Swim()
    {
        throw new NotImplementedException();
    }
}