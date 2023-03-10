

Lion lion = new Lion();

lion.Eat();

//Animal animal = new Animal();
//animal.Eat(); 

Console.WriteLine(lion.ToString());

Console.WriteLine(new Animal().Name);
Console.WriteLine(new Lion().Name);

class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Eating");
    }

    public virtual string Name
    {
        get
        {
            return "Jivotno";
        }
    }
}

class Lion : Animal
{

    public override string Name
    {
        get
        {
            return "Simba";
        }
    }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Everything I see");
    }

    public override string ToString()
    {
        return $"{base.ToString()} - Simbla";
    }
}