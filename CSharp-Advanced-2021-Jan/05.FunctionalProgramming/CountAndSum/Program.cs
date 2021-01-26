using System;
using System.Linq;

namespace CountAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSumAndCount(
                int.Parse,
                a => a.Length,
                array =>
                {
                    int sum = 0;
                    foreach (var item in array)
                    {
                        sum += item;
                    }

                    return sum;
                });
        }

        static void PrintSumAndCount(Func<string, int> parser,
            Func<int[], int> countGetter,
            Func<int[], int> sumCalculator)
        {
            int[] array =
                Console.ReadLine()
                .Split(", ")
                .Select(parser)
                .ToArray();

            Console.WriteLine(countGetter(array));
            Console.WriteLine(sumCalculator(array));
        }
    }
}
