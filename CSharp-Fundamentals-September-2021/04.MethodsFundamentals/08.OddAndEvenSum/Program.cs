using System;

namespace _08.OddAndEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int evenDigitsSum = GetDigitsSum(number, 0);
            int oddDigitsSum = GetDigitsSum(number, 1);

            Console.WriteLine(evenDigitsSum * oddDigitsSum);
        }

        static int GetDigitsSum(int number, int evenOddCheck)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == evenOddCheck)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }
    }
}
