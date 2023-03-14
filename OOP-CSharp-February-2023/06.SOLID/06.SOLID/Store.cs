using _06.SOLID.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class Store
    {
        private List<IPromotion> promotions;

        public Store(List<IPromotion> promotions)
        {
            Products = new List<Product>();

            this.promotions = promotions;
        }

        public List<Product> Products { get; set; }

        public void Buy(string productName)
        {
            Product product = Products.FirstOrDefault(p => p.Name == productName);
            if (product == null)
            {
                throw new ArgumentException("Product not found");
            }

            // take money from customer
            decimal price = product.Price;

            foreach (var promotion in promotions)
            {
                price -= promotion.GetPrice(product);
            }

            Console.WriteLine($"Buing {productName} for {price}");

            product.Quantity -= 1;
        }
    }
}
