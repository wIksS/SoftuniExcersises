using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            a = 6;
            List<int> list = new List<int>() { 1, 5, 11, 7, 17, 3, 9 };

            Console.WriteLine(list.All(x => x < 5));
            list = list.Where((n, index) => index % 2 == 0).ToList();

            Console.WriteLine(String.Join(",", list));

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Average());

            List<string> numbers = list
                .Where(n =>
                {
                    Console.WriteLine($"Checking.. {n}");
                    return n % 3 == 0;
                })
                .Select(n => $"({n.ToString()})")
                .ToList();

            Console.WriteLine(String.Join(",", numbers));
            //Console.WriteLine(list.Min());
        }
    }
}
