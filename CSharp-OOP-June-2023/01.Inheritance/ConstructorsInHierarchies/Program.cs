
MacbookPro macbook = new MacbookPro("Macbook PRO");


Console.WriteLine(macbook.Name);
class Product
{
    public Product(string name)
    {
        Name = name;
        Console.WriteLine("In Product");
    }
    public int Id { get; set; }

    public string Name { get; set; }
}

class Laptop : Product
{
    public Laptop(string name) : base(name)
    {
        Console.WriteLine("In Laptop");
    }
}

class AppleLaptop: Laptop
{
    public AppleLaptop(string name) : base(name)
    {
        Console.WriteLine("In AppleLaptop");
    }
}

class MacbookPro : AppleLaptop
{
    public MacbookPro(string name) : base(name)
    {
        Console.WriteLine("In MacbookPro");
    }
}
