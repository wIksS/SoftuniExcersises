using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum("5", "6"));
        }

        static long Sum(int a, int b)
        {
            return a + b;
        }
        static long Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
