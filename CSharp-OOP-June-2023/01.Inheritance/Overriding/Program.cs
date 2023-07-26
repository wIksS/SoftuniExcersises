
Laptop laptop = new Laptop();

laptop.PrintProduct();

Console.WriteLine(laptop);

class Product
{
    public virtual int Id { get; set; }
    public virtual void PrintProduct()
    {
        Console.WriteLine("Printing Product!");
    }

    public override string ToString()
    {
        return $"{Id}";
    }
}

class Laptop : Product
{
    public override int Id { get => base.Id; set => base.Id = value; }



    public override sealed void PrintProduct()
    {
        //base.PrintProduct();
        Console.WriteLine("Printing Laptop");
    }

    public override string ToString()
    {
        return $"Laptop -> {base.ToString()}";
    }

}