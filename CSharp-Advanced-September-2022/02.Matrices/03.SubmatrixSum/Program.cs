using System;

namespace _03.SubmatrixSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subMatrixRows =2;
            int subMatrixCols = 2;
            string[] sizes = Console.ReadLine().Split(", ");
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(", ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }

            int maxSum = 0;
            int squareStartRow = 0;
            int squareStartCol = 0;
            for (int row = 0; row < rows - subMatrixRows + 1; row++)
            {
                for (int col = 0; col < cols - subMatrixCols + 1; col++)
                {
                    int sum = 0;

                    for (int subRow = 0; subRow < subMatrixRows; subRow++)
                    {
                        for (int subCol = 0; subCol < subMatrixCols; subCol++)
                        {
                            sum += matrix[row+subRow, col+subCol];
                        }
                    }

                    if (sum > maxSum)
                    {
                        squareStartRow = row;
                        squareStartCol = col;
                        maxSum = sum;
                    }
                }
            }


            for (int subRow = 0; subRow < subMatrixRows; subRow++)
            {
                for (int subCol = 0; subCol < subMatrixCols; subCol++)
                {
                    Console.Write($"{matrix[squareStartRow + subRow, squareStartCol + subCol]} ");
                }

                Console.WriteLine();
            }

                    //Console.WriteLine($"{matrix[squareStartRow,squareStartCol]} {matrix[squareStartRow, squareStartCol + 1]}");

                    //Console.WriteLine($"{matrix[squareStartRow + 1, squareStartCol]} {matrix[squareStartRow + 1, squareStartCol + 1]}");

                    Console.WriteLine(maxSum);
        }
    }
}
