using System;

namespace ReadingMatrix
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

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"matrix[{row},{col}]=");
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
