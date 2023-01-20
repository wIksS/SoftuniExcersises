using System;
using System.Linq;

namespace _03.SquareSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareRows = 2;
            int squareCols = 2;
            int[,] matrix = ReadMatrixWithCommmas();

            int maxSum = matrix[0,0];
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentSum = 0;

                    
                    if (row > matrix.GetLength(0) - squareRows || col > matrix.GetLength(1) - squareCols)
                    {
                        continue;
                    }

                    for (int squareRow = 0; squareRow < squareRows; squareRow++)
                    {
                        for (int squareCol = 0; squareCol < squareCols; squareCol++)
                        {
                            currentSum += matrix[row + squareRow, col + squareCol];
                        }
                    }

                    //currentSum += matrix[row, col];
                    //currentSum += matrix[row + 1, col];
                    //currentSum += matrix[row, col + 1];
                    //currentSum += matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }


            for (int squareRow = 0; squareRow < squareRows; squareRow++)
            {
                for (int squareCol = 0; squareCol < squareCols; squareCol++)
                {
                    Console.Write(matrix[maxRow+squareRow,maxCol + squareCol] + " ");
                }

                Console.WriteLine();
            }

                    //Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
                    //Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");

                    Console.WriteLine(maxSum);
        }

        public static int[,] ReadMatrixWithCommmas()
        {
            string[] sizes = Console.ReadLine().Split(", ");
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            return matrix;
        }
    }


}
