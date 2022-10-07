using System;

namespace Cubes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] cube = new int[3, 3, 3];
            int counter = 1;
            for (int row = 0; row < cube.GetLength(0); row++)
            {
                for (int col = 0; col < cube.GetLength(1); col++)
                {
                    for (int depth = 0; depth < cube.GetLength(2); depth++)
                    {
                        cube[row, col, depth] = counter++;
                    }
                }
            }

            for (int row = 0; row < cube.GetLength(0); row++)
            {
                for (int col = 0; col < cube.GetLength(1); col++)
                {
                    for (int depth = 0; depth < cube.GetLength(2); depth++)
                    {
                        Console.Write($"{cube[row,col,depth]} ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
