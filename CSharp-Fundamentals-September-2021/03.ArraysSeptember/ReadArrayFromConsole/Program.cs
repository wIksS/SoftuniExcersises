using System;

namespace ReadArrayFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of array:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Array[{i}]=?");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
