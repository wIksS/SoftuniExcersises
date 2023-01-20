using System;

namespace MatrixSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int[,] matrix = new int[3, 4]
            {
                { 1,2,3,4 },
                { 1,2,3,4 },
                { 1,2,3,4 }
            };

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

        }
    }
}
