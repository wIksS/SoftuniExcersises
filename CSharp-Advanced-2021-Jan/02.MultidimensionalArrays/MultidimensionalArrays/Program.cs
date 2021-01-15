using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3,5]
                {
                    {1, 2,34,5,6 },
                    {1, 2,55,66,77 },
                    {1, 2,55,66,77 },

                };
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            int[,,,,] nDimension = new int[2, 2, 2, 2,2];
            nDimension[0, 0, 0, 0, 0] = 5;
            //matrix[0, 0] = 5;
            //matrix[0, 1] = 7;
            //matrix[1, 0] = 3;
            //matrix[1, 1] = 4;

            Console.WriteLine(matrix[0,3]);
        }
    }
}
