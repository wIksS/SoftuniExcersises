using System;

namespace ArrayNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long[] array = new long[n];

            for (long i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine($"array[{i}]={array[i]}");

            }

            for (int i = 0; i < array.Length; i++)
            {
                //Console.WriteLine($"array[{i}]={array[i]}");
            }

            Console.WriteLine(array[array.Length-1]);
        }
    }
}
