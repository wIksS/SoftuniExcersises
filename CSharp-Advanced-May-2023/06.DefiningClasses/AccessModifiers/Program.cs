
Shoe nike = new Shoe();
nike.model = "Nike Air";

//nike.size = 42;

nike.BuyShoe();

class Shoe
{
    public string model;

    private int size = 42;

    public void BuyShoe()
    {
        Console.WriteLine("Buying shoe!");
        PrintShoe();
    }

    private void PrintShoe()
    {
        Console.WriteLine($"{model} - {size}");
    }
}