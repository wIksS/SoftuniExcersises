using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores
{
    public class Store
    {
        private readonly IProductsDatabase productsDatabase;

        public Store(IProductsDatabase productsDatabase)
        {
            this.productsDatabase = productsDatabase;
            Products = productsDatabase.GetAllProducts().ToList();
        }

        public List<Product> Products { get; set; }

        public Product FindProduct(string name)
        {
            return Products.FirstOrDefault(p => p.Name == name);
        }

        public Product GetCheapest()
        {
            return Products.OrderBy(p => p.Price).First();
        }

        public List<Product> GetOutOfStock()
        {
            return Products.Where(p => p.Quantity == 0).ToList();
        }

        public void AddProduct(Product product)
        {
            //Products.Add(product);

            productsDatabase.SaveProducts(Products);
        }
    }
}
