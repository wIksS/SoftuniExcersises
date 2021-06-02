using System;

namespace PrintFirstNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the numbers from 0 - 1000
            int[] array = new int[5];

            // 0 1 2 3 4
            // 5
            for (int i = 0; i <= array.Length; i++)
            {
                array[i] = i * 5;

                Console.WriteLine(array[i]);
            }

            Console.WriteLine(array[array.Length-1]);
        }
    }
}
