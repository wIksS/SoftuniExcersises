using System;

namespace ReturningValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateSum(5,6));
            int sum = CalculateSum(1, 1);
            int[] arr = GenerateArray();

            int input = int.Parse(Console.ReadLine());
        }

        static int CalculateSum(int a, int b)
        {
            Console.WriteLine("A +b");

            if (5 <a)
            {
                return a + b;
            }
            else
            {
                return b;
            }
        }

        static int[] GenerateArray()
        {
            return new int[] { 1, 2, 3, 4 };
        }
    }
}
