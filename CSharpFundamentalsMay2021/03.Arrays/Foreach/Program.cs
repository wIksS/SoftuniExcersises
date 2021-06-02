using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] input = Console.ReadLine().Split();
            foreach (var text in input)
            {               
                Console.WriteLine(text);
            }

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
        }
    }
}
