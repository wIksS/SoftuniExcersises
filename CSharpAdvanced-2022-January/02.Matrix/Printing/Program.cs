using System;

namespace Printing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            //{
            //    {1,2,3,4 },
            //    {5,6,7,8 },
            //    {9, 10, 11, 12},
            //    {13,14,15, 16 },
            //};

            Console.WriteLine($"Rows: {matrix.GetLength(0)}");
            Console.WriteLine($"Cols: {matrix.GetLength(1)}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] < 10)
                    {
                        Console.Write($" {matrix[row, col]} ");
                    }
                    else
                    {
                        Console.Write($"{matrix[row, col]} ");
                    }
                }

                Console.WriteLine();
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
