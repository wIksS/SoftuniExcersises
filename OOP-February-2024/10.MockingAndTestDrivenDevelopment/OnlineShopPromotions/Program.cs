

using Newtonsoft.Json;
using OnlineShopPromotions;

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Nike",
        Id=1,
        Price=100
    },
    new Product()
    {
        Name = "Djapanka Adidas",
        Id=1,
        Price=220
    },
    new Product()
    {
        Name = "Djapanka",
        Id=1,
        Price=1000
    },
};

Store store = new Store(new Database<Product>());

//store.AddProduct(products[0]);
//store.AddProduct(products[1]);
//store.AddProduct(products[2]);
