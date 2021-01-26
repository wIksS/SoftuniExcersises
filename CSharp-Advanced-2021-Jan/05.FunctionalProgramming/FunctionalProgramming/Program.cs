using System;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 2, 7, 8, 9 };

            var input = Console.ReadLine()
                .Split()
                .Select(Parser)
                .ToArray();

            array = array.OrderBy(Sort).ToArray();

            Console.WriteLine(String.Join(" ", array));
        }

        static int Parser(string n)
        {
            return int.Parse(n);
        }

        static int Sort(int n)
        {
            return n;
        }
    }
}
