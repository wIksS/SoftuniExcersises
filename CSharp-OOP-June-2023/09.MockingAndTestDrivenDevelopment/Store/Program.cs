
using Store;

Product product = new Product();

product.Id = 1;
product.Name = "Nike AIR";

ProductTextDatabase db = new ProductTextDatabase();
Store.Store store = new Store.Store(db);

store.AddProduct(product);
store.AddProduct(new Product() { Name = "Obuvchici", Id = 2, Description = "Nai udobnite" });
store.AddProduct(new Product() { Name = "Obuvchici5", Id = 3, Description = "Nai udobnite" });

