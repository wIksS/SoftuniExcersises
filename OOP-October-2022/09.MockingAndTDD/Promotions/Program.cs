using Promotions.Contracts;
using System;
using System.Collections.Generic;

namespace Promotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductDatabase db = new TextProductDatabase();

            List<Product> products = new List<Product>()
            {
                new Product(1,"Olio", 9999),
                new Product(2,"Zehtin", 10),
                new Product(2,"Domati", 2),
            };

            db.Save(products);

            ProductsService service = new ProductsService(db, new PromotionsService(DateTime.Now));

            foreach (var product in service.GetAllProductsForToday())
            {
                Console.WriteLine(product);
            }
        }
    }
}
