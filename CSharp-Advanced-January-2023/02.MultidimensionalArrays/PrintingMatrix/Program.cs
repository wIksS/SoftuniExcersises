using System;

namespace PrintingMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [[1,2,3], [1,2,3], [1,2,3] ]
            int[,] matrix =
            {
                {5, 6, 3},
                {1, 2, 3 },
                {8, 3, 2 },
                {4, 5, 6 }
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
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
