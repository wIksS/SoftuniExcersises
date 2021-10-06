using System;

namespace _03.PrintTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintTriangleLine(i);
            }

            for (int i = n-1; i > 0; i--)
            {
                PrintTriangleLine(i);
            }
        }

        static void PrintTriangleLine(int line)
        {
            for (int i = 1; i <= line; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
