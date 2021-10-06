using System;
using System.Linq;

namespace ReadingOnOneLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[5];
            // 5,6 7 1 2 3
            //reading with commas
    //        int[] array =
    //Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int[] array = 
                Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]={array[i]}");
            }
        }
    }
}
