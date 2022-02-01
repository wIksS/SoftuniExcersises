using System;
using System.Linq;

namespace _02.MatrixColSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int colSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                   // Console.Write($" {matrix[row,col]}");
                   colSum+=matrix[row,col];
                }

                Console.WriteLine(colSum);
            }
        }
    }
}
