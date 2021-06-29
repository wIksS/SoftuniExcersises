using System;

namespace _01.DataStructuresAndComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            // O(3 + 3n + 3(n^2))
            Console.WriteLine(3 + 3 * n + 3 * (n * n));
            // O(n^2)
            Console.WriteLine(n *n);
        }

        //BigO()

        // O(3 + 3n + 3(n^2))
        // O (3 + 15 + 75)
        // O(93)

        static long GetOperationsCount(int n)
        {
            // 3 + 3n + 3(n^2)
            long counter = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    counter++;

            for (int i = 0; i < n; i++)
            {

            }
            for (int i = 0; i < n; i++)
            {

            }
            for (int i = 0; i < n; i++)
            {

            }
            for (int i = 0; i < n; i++)
            {

            }
            for (int i = 0; i < n; i++)
            {

            }
            for (int i = 0; i < n; i++)
            {

            }
            for (int i = 0; i < n; i++)
            {

            }
            for (int i = 0; i < n; i++)
            {

            }
            for (int i = 0; i < n; i++)
            {

            }
            for (int i = 0; i < n; i++)
            {

            }
            return counter;
        }
    }
}
