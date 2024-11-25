
Persian persian = new Persian();

class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal Created");
    }

    public string Name { get; set; }
}

class Cat : Animal
{
    public Cat()
    {
        Console.WriteLine("Cat created");
    }

    public string FavoritePillow { get; set; }

    public void Eat()
    {
    }
}

class Persian : Cat
{
    public string BirthCertificate { get; set; }
}