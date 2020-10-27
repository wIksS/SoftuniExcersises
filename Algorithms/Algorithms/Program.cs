using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Neshto si");
            //}

            Loop(3);

            int[] array = new int[] { 1, 2, 3 };
            Traverse(array, 0);
        }

        static void Traverse<T>(T[] collection, int index)
        {
            if (index == collection.Length)
            {
                return;
            }

            Console.WriteLine(collection[index]);
           // Console.WriteLine("Before recursion");

            Traverse(collection, index + 1);

            Console.WriteLine(collection[index]);
        }

        private static void Loop(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine("Neshto si");
            Loop(n - 1);
        }
    }
}
