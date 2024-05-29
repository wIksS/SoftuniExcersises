
using OnlineStorePromotions;
using System.Reflection;

List<IPromotionStrategy> promotions = new List<IPromotionStrategy>();
var types = Assembly.GetExecutingAssembly()
    .GetTypes().Where(t => typeof(IPromotionStrategy).IsAssignableFrom(t) && t.Name != "IPromotionStrategy");

foreach (var type in types)
{
    promotions.Add(Activator.CreateInstance(type) as IPromotionStrategy);
}

List<Product> products = new List<Product>
{
    new Product{ Id = 1, Name = "Nivea", Price=10},
    new Product{ Id = 1, Name = "Head&Shoulders", Price=20},
    new Product{ Id = 1, Name = "Old Spice", Price=100},
};

Shop shop = new Shop(promotions) { Products=products};
User user = new User("Dimitrichko") { Age=15};

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{products[i].Name} - {shop.GetPrice(products[i], user)}");
}
