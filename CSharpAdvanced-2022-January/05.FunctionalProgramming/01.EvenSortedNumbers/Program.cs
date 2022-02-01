using System;
using System.Linq;

namespace _01.EvenSortedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(String.Join(", ", numbers.Select(x=>x+1)));

            numbers = numbers.Where(x =>
            {
                return x % 2 == 0;
            }).OrderBy(x => x).ToArray();

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
