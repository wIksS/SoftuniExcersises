using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Store
    {
        public Store()
        {
            Products = new List<Product>();
        }

        public List<Product> Products { get; set; }

        public decimal GetProductPrice(string name)
        {
            Product product = Products.FirstOrDefault(x=> x.Name == name);
            decimal price = product.Price;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                price *= 0.8m;
            }
            if (DateTime.Now.Date.Day == 1)
            {
                price *= 0.5m;
            }
            if (DateTime.Now.Date.Month ==12 && DateTime.Now.Date.Day == 25)
            {
                price *= 0.6m;
            }
            if (DateTime.Now.Date.Month == 2 && DateTime.Now.Date.Day == 14)
            {
                price *= 0.9m;
            }

            Console.WriteLine("Checking if user has been with us over 5 years");
            //
            //
            //
            Console.WriteLine("Checking if user has spent over 5000lv");
            //
            //
            //
            Console.WriteLine("Checking age > 30");
            //
            //
            //

            return price;
        }
    }
}
