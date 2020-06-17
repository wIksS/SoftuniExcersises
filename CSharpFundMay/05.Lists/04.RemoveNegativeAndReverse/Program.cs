using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i--);
                }
            }

            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
