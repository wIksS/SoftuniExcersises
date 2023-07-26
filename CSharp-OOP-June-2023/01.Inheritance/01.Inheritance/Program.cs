

using _01.Inheritance;

Laptop macbook = new Laptop()
{
    Name = "Macbook Pro",
    Rating=2,
    ImageURLs= new string[5] {"1.png", "2.png", "3.png", "4.png", "5.png"}
};

macbook.Price = int.MaxValue;

macbook.PrintProduct();

macbook.Capacity = LaptopCapacity.GB512;

TShirt shirt = new TShirt()
{
    Name = "Teniska s Macbook Pro Snimka",
    Rating = 5,
    ImageURLs = new string[5] { "1.png", "2.png", "3.png", "4.png", "5.png" }
}; ;

shirt.Fit = "Regular";


shirt.PrintProduct();