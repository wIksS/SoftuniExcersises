using System;

namespace EnterNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter a number n
            // Enter n numbers in an array
            // Enter the sum of those numbers
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Console.WriteLine($"arr[{i}]={array[i]}");
            }

            Console.WriteLine($"Sum is: {sum}");
        }
    }
}
