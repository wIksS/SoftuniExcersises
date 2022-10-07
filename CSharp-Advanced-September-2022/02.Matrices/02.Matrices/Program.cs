using System;

namespace _02.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] matrix2 = new int[5, 15,166];
            Console.WriteLine(matrix2.GetLength(0));
            Console.WriteLine(matrix2.GetLength(1));
            Console.WriteLine(matrix2.GetLength(2));
            return;

            int[,] matrix = new int[3, 3]
            {
                {1,2,3 },
                {4,5,6},
                {7,8,9 },
            };

            Console.WriteLine(matrix[1,1]);

            int x = matrix[0, 0];

            int[][] array2d = new int[3][];
            array2d[0] = new int[4]
                {1,2,3,4 };
            array2d[1] = new int[4]
        {4,5,6,7 };
            int[] firstRow = array2d[0];
            int[] secondRow = array2d[1];

            Console.WriteLine(String.Join(",", firstRow));
            Console.WriteLine(String.Join(",", secondRow));

            //matrix[0, 0] = 1;
            //matrix[0, 1] = 2;
            //matrix[0, 2] = 3;
            //matrix[0, 3] = 4;

            //matrix[1, 0] = 5;
            //matrix[1, 1] = 6;
            //matrix[1, 2] = 7;
            //matrix[1, 3] = 8;

            //matrix[2, 0] = 1;
            //matrix[2, 1] = 1;
            //matrix[2, 2] = 1;
            //matrix[2, 3] = 1;
        }
    }
}
