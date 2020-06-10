using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int digitsSum = 0;
                int number = i;
                while (number > 0)
                {
                    digitsSum += number % 10;
                    number /= 10;
                }

                bool isSpecial = digitsSum == 5 || digitsSum == 7 || digitsSum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
