using System;

namespace PrintingMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4]
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,1,2,3 }
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
