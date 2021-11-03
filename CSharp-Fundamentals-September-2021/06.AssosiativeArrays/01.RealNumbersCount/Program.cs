using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RealNumbersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split()
                .Select(double.Parse).ToList();

            SortedDictionary<double, int> doubleOccurances = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!doubleOccurances.ContainsKey(numbers[i]))
                {
                    doubleOccurances.Add(numbers[i], 0);
                }

                doubleOccurances[numbers[i]]++;
            }

            foreach (var item in doubleOccurances)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
