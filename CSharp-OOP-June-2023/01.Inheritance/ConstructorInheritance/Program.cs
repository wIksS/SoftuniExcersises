
Laptop laptop = new Laptop("Macbook");
Laptop laptop2 = new Laptop();

laptop.PrintLaptop();


class Product
{
    public Product()
    {
        Console.WriteLine("Empty constructor product");
    }
    public Product(string name)
    {
        Name = name;
        Console.WriteLine("I am in product");
    }
    public int Id { get; set; }

    public string Name { get; set; }
}

class Laptop: Product
{
    public Laptop()
    {
        Console.WriteLine("In empty laptop");
    }
    public Laptop(decimal price) : base("Laptop")
    {
        Console.WriteLine(price);
    }
    public Laptop(string name) : base(name)
    {
        Console.WriteLine("In laptop constructor");
    }

    public void PrintLaptop()
    {
        Console.WriteLine($"{Name} {base.Id}");
    }
}

