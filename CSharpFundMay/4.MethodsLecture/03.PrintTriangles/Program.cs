using System;
using System.Collections.Generic;

namespace _03.PrintTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
  
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);

        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintNumbersBetween(5,i);
            }
            for (int i = n-1; i > 0; i--)
            {
                PrintNumbersBetween(5,i);
            }
        }

        static void PrintNumbersBetween(int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
