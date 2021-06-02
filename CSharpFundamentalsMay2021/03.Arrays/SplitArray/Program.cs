using System;

namespace SplitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //3
            //1
            //2
            //3

            // 1 2 3 5 6 7
            string[] splitted = Console.ReadLine().Split();
            int[] numbers = new int[splitted.Length];
            for (int i = 0; i < splitted.Length; i++)
            {
                numbers[i] = int.Parse(splitted[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"[{i}] = {numbers[i]}");
            }














            //1
            //2
            //3
            //pesho
            //gosho
            //4


        }
    }
}
