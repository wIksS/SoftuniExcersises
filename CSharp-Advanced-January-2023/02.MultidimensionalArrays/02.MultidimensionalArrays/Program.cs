using System;

namespace _02.MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];

            matrix[0] = new int[3] { 55, 67, 31 };
            matrix[1] = new int[3] { 1, 2, 3 };
            matrix[2] = new int[3] { 8, 3, 2 };

            Console.WriteLine(matrix[2][1]);

        }
    }
}
