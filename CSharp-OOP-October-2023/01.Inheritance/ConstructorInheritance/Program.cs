
Fish fish = new Fish("Dori", 100);



class Animal
{
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine("In Parent Constructor");
    }

    public Animal()
    {
        Console.WriteLine("In Empty Parent Constructor");
    }

    public string Name { get; set; }
}


class Fish : Animal
{
    
    public Fish(string name, int water)
    {
        Water = water;
        Console.WriteLine("In Fish constructor");
    }

    public int Water{ get; set; }
}