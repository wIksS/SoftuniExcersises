using System;

namespace Diagonals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {1,2,3,4 },
                {5,6,7,8 }, 
                {9,10,11,12 },
                {13,14,15,16 }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i,i]);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i,matrix.GetLength(0) - 1- i]);
            }
        }
    }
}
