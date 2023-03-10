
using OpenClosePrinciple;

Store store = new Store();

store.Products.Add(new Product()
{
    Name = "Teniska",
    Price = 100,
    Quantity = 60
});

store.Products.Add(new Product()
{
    Name = "Obuvki",
    Price = 200,
    Quantity = 60
});


store.Products.Add(new Product()
{
    Name = "4asovni4e",
    Price = 500,
    Quantity = 30
});

while (true)
{
    Console.WriteLine("What do you want to buy?");
    string productName = Console.ReadLine();

    store.Buy(productName);
}