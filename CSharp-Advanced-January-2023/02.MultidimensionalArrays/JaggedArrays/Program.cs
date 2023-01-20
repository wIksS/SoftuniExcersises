using System;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 2 3
            // 1 2
            // 4 5 6 7 8

            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[3];

            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 2;
            jaggedArray[0][2] = 3;


            jaggedArray[1] = new int[2];

            jaggedArray[1][0] = 1;
            jaggedArray[1][1] = 2;

            jaggedArray[2] = new int[5];

            jaggedArray[2][0] = 4;
            jaggedArray[2][1] = 5;
            jaggedArray[2][2] = 6;
            jaggedArray[2][3] = 7;
            jaggedArray[2][4] = 8;

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
