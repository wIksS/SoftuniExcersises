using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(", ").Select(decimal.Parse).ToList();

            Func<decimal, decimal> vatAdder = n => n + n * 0.2m;
            numbers = numbers.Select(vatAdder).ToList();

            numbers.ForEach(n => Console.WriteLine($"{n:f2}"));
        }
    }
}
