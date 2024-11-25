
using OpenClosedPrinciple;

StoreOC store = new StoreOC();

store.Products.Add(new Product() { Name = "C#", Price = 100 });

Console.WriteLine($"Discounted price C# is: {store.GetProductPrice("C#")}");