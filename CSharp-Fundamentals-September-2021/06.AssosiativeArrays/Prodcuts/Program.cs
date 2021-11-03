using System;
using System.Collections.Generic;

namespace Prodcuts
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>()
            {
                { "kiwi",100},
                { "apple",1}
            };

            productPrices["mandarina"] = 100;
            productPrices["orange"] = 5;
            productPrices["banana"] = 1;

            Console.WriteLine(productPrices["kiwi"]);
            Console.WriteLine(productPrices["apple"]);
            //productPrices.Remove("banana");

            Console.WriteLine(String.Join(",", productPrices));


            Console.WriteLine($"Banana-> {productPrices["banana"]}");

            string key = "orange";
            Console.WriteLine($"Contains key {key} -> {productPrices.ContainsKey(key)}");

             key = "banana";
            Console.WriteLine($"Contains key {key} -> {productPrices.ContainsKey(key)}");

             key = "notvalid";
            Console.WriteLine($"Contains key {key} -> {productPrices.ContainsKey(key)}");
            //Console.WriteLine(productPrices["no real product"]);
        }
    }
}
