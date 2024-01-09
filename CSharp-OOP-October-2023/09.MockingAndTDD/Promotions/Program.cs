

using Moq;
using Promotions;


Mock<IPromotionsService> mockPromotionsService = new Mock<IPromotionsService>();

mockPromotionsService.Setup(p => p.GetPrice(It.IsAny<decimal>())).Returns(55);

IPromotionsService promotionsService = mockPromotionsService.Object;

Console.WriteLine($"Promotions Service GetPrice: {promotionsService.GetPrice(100)}");

Store store = new Store(
    new List<Product>()
    {
        new Product(){ Name = "C# OOP", Price =100},
        new Product(){ Name = "C# Advanced", Price =120}
    }, promotionsService);

Console.WriteLine(store.GetProductPrice("C# OOP"));

