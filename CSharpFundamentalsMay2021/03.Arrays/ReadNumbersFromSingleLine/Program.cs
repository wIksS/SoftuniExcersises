using System;
using System.Linq;

namespace ReadNumbersFromSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 5 1 2 3 4
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"[{i}]={numbers[i]}");
            }
        }
    }
}
