using System;
using System.Threading;

namespace _02.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
            {
                { 4, 5, 6},
                { 11, 3, 9},
                { 1,2,3}
            };


            Console.Write($"{matrix[0, 0]} ");
            Console.Write($"{matrix[0, 1]} ");
            Console.Write($"{matrix[0, 2]} ");
            Console.WriteLine();
            Console.Write($"{matrix[1, 0]} ");
            Console.Write($"{matrix[1, 1]} ");
            Console.Write($"{matrix[1, 2]} ");

            Console.WriteLine();
            Console.Write($"{matrix[2, 0]} ");
            Console.Write($"{matrix[2, 1]} ");
            Console.Write($"{matrix[2, 2]} ");

        }
    }
}
