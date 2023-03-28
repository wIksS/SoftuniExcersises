
using SerializationWorkshop;

Product product = Serializator.Load<Product>();

if (product == null)
{
    product = new Product()
    {
        Id = 1,
        Price = 200,
        Model = "Top Model",
        Quantity = 5,
        Test = new Test()
    };
}
 

Serializator.Save(product);

Serializator.Save(DateTime.Now);

class Product
{
    public int Id { get; set; }

    public decimal Price { get; set; }

    public int Quantity{ get; set; }

    public string Model { get; set; }

    public Test Test { get; set; }

    public Product Product2 { get; set; }

    public string Save()
    {
        return $"Id:{Id}|-|Price:{Price}|-|Quantity:{Quantity}|-|Model:{Model}|-|";
    }
}