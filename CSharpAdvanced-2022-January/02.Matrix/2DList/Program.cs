using System;
using System.Collections.Generic;
using System.Linq;

namespace _2DList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>();
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            for (int row = 0; row < rows; row++)
            {
                matrix.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
            }
            Console.WriteLine("\n\n");

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
