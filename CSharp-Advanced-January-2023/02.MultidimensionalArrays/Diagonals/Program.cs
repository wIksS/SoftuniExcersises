using System;

namespace Diagonals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;// int.Parse(Console.ReadLine());
            int cols = 4;// int.Parse(Console.ReadLine());

            int[,] matrix = new int[4, 4]
            {
                {1,2,3,4 },
                {5,6,7,8},
                {9,10,11,12},
                {11,12,13,14},
            };

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        matrix[row, col] = row + col;
            //    }
            //}

            PrintMatrix(matrix);
            Console.WriteLine();
            for (int i = rows - 1; i >= 0; i--)
            {
                Console.Write(matrix[i, i] + " ");
            }
            // 4 4 i= 0
            // 
            Console.WriteLine();
            for (int i = rows-1; i >=0; i--)
            {
                Console.Write(matrix[rows - i - 1, i] + " ");
            }

            // Find the sum of 2 diagonals
        }

        public static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("Printing matrix: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
