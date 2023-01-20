using System;
using System.Linq;

namespace ReadingMatrixShort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cols?");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            // 1 2 3 4
            // 5 6 7 8

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0;row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
