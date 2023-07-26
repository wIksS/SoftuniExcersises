

Laptop laptop = new Laptop();
laptop.PrintPrice(true);
laptop.Price = "Price";

class Product
{
    public decimal Price { get; set; }
}

class Laptop : Product
{
    public string Price { get; set; }

    public void PrintPrice(bool Price)
    {
        bool value = Price;

        string stringVal = this.Price;

        decimal decimalVal = base.Price;
    }
}