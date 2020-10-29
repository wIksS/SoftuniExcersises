using System;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2,  9 };

            Console.WriteLine(Sum(array, 0));
        }

        private static int Sum(int[] array, int startIndex)
        {
            if (startIndex == array.Length)
            {
                return 0;
            }

            int currentSum = array[startIndex] + Sum(array, startIndex + 1);

            return currentSum;
        }
    }
}
