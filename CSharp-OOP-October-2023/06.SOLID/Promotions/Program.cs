
using Promotions;

Store store = new Store(new List<Product>()
{
    new Product(){Price = 100},
    new Product(){Price = 1000},
});

store.PrintProducts();