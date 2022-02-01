using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = ReadJaggedArray(rows);

            PrintJaggedArray(jaggedArray);
        }

        public static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]}");
                }

                Console.WriteLine();
            }
        }

        public static int[][] ReadJaggedArray(int rows)
        {
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine($"How many cols for row: {row}");
                int cols = int.Parse(Console.ReadLine());
                jaggedArray[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    jaggedArray[row][col] = int.Parse(Console.ReadLine());
                }
            }

            return jaggedArray;
        }
    }
}
