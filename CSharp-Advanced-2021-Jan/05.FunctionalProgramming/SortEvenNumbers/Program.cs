using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(String.Join(", ", array));
        }
    }
}
