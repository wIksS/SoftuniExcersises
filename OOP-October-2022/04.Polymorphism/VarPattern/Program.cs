using System;
using System.Collections.Generic;
using System.Linq;

namespace VarPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get numbers divisible by 10 and are between 100, 500

            List<int> numbers = Enumerable.Range(0, 300)
                .Where(n => n % 10 is var result && result >= 1 && result <= 3)
                .ToList();

            Console.WriteLine(string.Join(",",numbers));
        }
    }
}
