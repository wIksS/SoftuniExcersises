using System;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // a => a < 5
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] smaller = array.Where((int n, int x) =>
            {
                Console.WriteLine("Checking from lambda" + n);
                Console.WriteLine(x);
                return n < 5;
            })
                .Where(n => true)
                .Select(Multiply)
                .ToArray();

            Console.WriteLine(string.Join(" ", smaller));
            //Console.WriteLine(IsSmallerThanFive(4));

            //Func<int, int> x = a => a / 2;
        }

        static int Multiply(int n)
        {
            return n * 2;
        }

        static bool IsSmallerThanFive(int a)
        {
            Console.WriteLine("Checking: " + a);
            return a < 5;
        }
    }
}
