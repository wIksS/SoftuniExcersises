

using Stores;




Store store = new Store(new ProductsDatabase());

Console.WriteLine(store.GetCheapest());