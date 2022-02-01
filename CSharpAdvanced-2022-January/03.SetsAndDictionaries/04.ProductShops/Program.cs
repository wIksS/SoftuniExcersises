using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _04.ProductShops
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            SortedDictionary<string, Dictionary<string, double>> productShops = new SortedDictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();
            while (input != "Revision")
            {
                var splitted = input.Split(", ");
                var shop = splitted[0];
                var product = splitted[1];
                var price = double.Parse(splitted[2]);

                if (!productShops.ContainsKey(shop))
                {
                    productShops.Add(shop, new Dictionary<string, double>());
                }

                productShops[shop].Add(product, price);
                input = Console.ReadLine();
            }

            //productShops = productShops.OrderBy(x => x.Key)

            //    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var shop in productShops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }

//            fantastico->
//Product: apple, Price: 1.2
//Product: grape, Price: 2.2
//kaufland->
//Product: banana, Price: 1.1
//lidl->
//Product: juice, Price: 2.3

        }
    }
}
