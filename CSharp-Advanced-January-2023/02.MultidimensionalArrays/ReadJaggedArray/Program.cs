using System;
using System.Linq;

namespace ReadJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Rows?");
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            //for (int row = 0; row < rows; row++)
            //{
            //    Console.WriteLine("How Many Cols?");
            //    int cols = int.Parse(Console.ReadLine());

            //    jaggedArray[row] = new int[cols];

            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write($"jaggedArray[{row}][{col}]=");
            //        jaggedArray[row][col] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
