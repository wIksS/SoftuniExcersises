//string str= "5";
//char ch = '2';

//number = ch;
//Console.WriteLine(number);

Dog dog = new Dog();
Fish fish = new Fish();
Animal animal;

animal = dog;
animal = fish;

if (new Random().Next() % 2 == 0)
{
    animal = new Fish();
}
else
{
    animal = new Dog();
}

animal.Eat();

abstract class Animal
{
    public abstract void Eat();
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Iskam oshte");
    }
}

class Fish : Animal
{
    public override void Eat()
    {
        Console.WriteLine("brrrrr");
    }
}