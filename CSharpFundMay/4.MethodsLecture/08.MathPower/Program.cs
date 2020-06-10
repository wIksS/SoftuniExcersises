using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculatePower(n,power));
        }

        static int CalculatePower(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
