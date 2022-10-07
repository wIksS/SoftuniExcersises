using System;

namespace ReadingJaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                Console.Write($"Cols? jagged[{row}]=");
                int cols = int.Parse(Console.ReadLine());
                jaggedArray[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    jaggedArray[row][col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                Console.WriteLine();
            }

            foreach (int[] array in jaggedArray)
            {
                Console.WriteLine(String.Join(",",array));
            }
        }
    }
}
