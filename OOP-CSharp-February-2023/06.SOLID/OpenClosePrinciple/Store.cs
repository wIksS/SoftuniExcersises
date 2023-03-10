using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class Store
    {
        public Store()
        {
            Products = new List<Product>();
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

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                price -= price * 0.2m;
                Console.WriteLine("20% off because it is Monday! yay");
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                price -= price * 0.5m;
                Console.WriteLine("50% off because it is Monday! yay");
            }
            if (DateTime.Now.Month == 2 && DateTime.Now.Day == 14)
            {
                // 100 rows
                price += price * 0.3m;
                Console.WriteLine("30% up because it is St Valentine! Ouch why do you wait until last minute??");
            }
            if (DateTime.Now.Month == 12 && product.Quantity > 50)
            {
                price -= price * 0.8m;
                Console.WriteLine("Final licvidation");
            }
            if (DateTime.Now.Hour > 20)
            {
                price -= price * 0.1m;
                Console.WriteLine("After 8 pm");
            }


            Console.WriteLine($"Buing {productName} for {price}");

            product.Quantity -= 1;
        }
    }
}
