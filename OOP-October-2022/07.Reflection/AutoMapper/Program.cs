using System;
using System.Collections.Generic;

namespace AutoMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            List<Product> products = db.LoadProducts<Product>();
            while (true)
            {
                Console.WriteLine($"Name of product?");
                string name = Console.ReadLine();
                Console.WriteLine($"Company of product?");
                string comapny = Console.ReadLine();
                Console.WriteLine($"Price of product?");
                decimal price = decimal.Parse(Console.ReadLine());

                products.Add(new Product() { Company = comapny, Name = name, Price = price });

                db.SaveProducts(products);
            }
        }
    }
}
