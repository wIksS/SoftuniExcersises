using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            string direction = "right";
            int row = 0;
            int col = 0;
            for (int i = 0; i < n * n; i++)
            {
                matrix[row, col] = i + 1;
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "up")
                {
                    row--;
                }

                if ((col == n || IsSpaceOccupied(matrix, row, col, n)) && direction=="right" )
                {
                    col--;
                    row++;
                    direction = "down";
                }


                if ((row == n || IsSpaceOccupied(matrix, row, col, n)) && direction == "down")
                {
                    row--;
                    col--;
                    direction = "left";
                }


                if ((col == -1 || IsSpaceOccupied(matrix, row, col, n)) && direction == "left")
                {
                    col++;
                    row--;
                    direction = "up";
                }
                if ((row == -1 || IsSpaceOccupied(matrix, row, col, n)) && direction == "up")
                {
                    row++;
                    col++;
                    direction = "right";
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] < 10)
                    {
                        Console.Write(" " + matrix[i, j] + " ");

                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");

                    }
                }

                Console.WriteLine();
            }
        }

        static bool IsSpaceOccupied(int[,] matrix, int row, int col, int n)
        {
            return row >= 0 && col >= 0 && row < n && col < n && matrix[row,col] != 0;
        }
    }
}
