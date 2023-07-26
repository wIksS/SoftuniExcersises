using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string name, decimal price, int rating, string[] imageUrls)
        {
            Name = name;
            Price = price;
            Rating = rating;
            ImageURLs = imageUrls;
        }

        public decimal Price { get; set; }

        public string Name { get; set; }

        public int Rating { get; set; }

        public string[] ImageURLs { get; set; }

        public virtual void PrintProduct()
        {
            Console.WriteLine($"{new string('*', Rating)} Product: {Name}, Price: {Price}, Images: {String.Join(",",ImageURLs)}");
        }
    }
}
