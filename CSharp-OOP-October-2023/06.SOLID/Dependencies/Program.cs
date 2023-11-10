

using Dependencies;
using Dependencies.Contracts;

IPromotionService promotion = new NoPromotionService();   

Store store = new Store(promotion, new List<Product>()
{
    new Product(){Name="Obuvki", Price=100},
    new Product(){Name="Teniska", Price=50},
    new Product(){Name="Qke", Price=300},
});


store.PrintProducts();

Store store2 = new Store(new PromotionService(), new List<Product>()
{
    new Product(){Name="Obuvki", Price=100},
    new Product(){Name="Teniska", Price=50},
    new Product(){Name="Qke", Price=300},
});


store2.PrintProducts();