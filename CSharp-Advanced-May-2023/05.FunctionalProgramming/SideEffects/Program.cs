

class Store
{
    int productsQuantity = 100;

    void PrintProduct()
    {
        productsQuantity -= 1;
        Console.WriteLine("Printing all the products");
    }
}