using System;

namespace Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= x;
            }

            //Console.WriteLine(result);

            Console.WriteLine(Pow(x,n));
        }

        static int Pow(int x, int n)
        {
            if (n == 1)
            {
                return x;
            }

            Console.WriteLine("Before recursion");
            int current = x * Pow(x, n - 1);
            Console.WriteLine("After recursion");
            return current;
        }
    }
}
