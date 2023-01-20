using System;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 3];

            matrix[0, 0] = 55;
            matrix[0, 1] = 67;
            matrix[0, 2] = 31;
            matrix[1, 0] = 1;
            matrix[1, 1] = 2;
            matrix[1, 2] = 3;

            Console.WriteLine(matrix[0,0]);
            Console.WriteLine(matrix[0,1]);
            Console.WriteLine(matrix[0,2]);
        }
    }
}
