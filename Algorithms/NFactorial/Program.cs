using System;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }

        private static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            Console.WriteLine($"{n}! = {n} * {n-1}!");
            int nMinus1Factorial = Factorial(n - 1);

            Console.WriteLine($"{n}! = {n} * {nMinus1Factorial}");
            return n * nMinus1Factorial;
        }
    }
}
