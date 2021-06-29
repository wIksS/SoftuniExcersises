using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Hashset
{
    class Program
    {
        // Array student names
        // Write a function that accepts student and returns true/false
        // weather student is in the array
        static void Main(string[] args)
        {
            int count = 100000000;//int.Parse(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] =i;
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();
            bool isThere = false;
            for (int i = 0; i < 0; i++)
            {
                isThere = LinearFind(array, -5);
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
            HashSet<int> set = new HashSet<int>(array);
            watch.Start();
            for (int i = 0; i < count; i++)
            {
                isThere = ConstantTimeFind(set, -5);
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        // O(n)
        static bool LinearFind(int[] array, int element)
        {
            return array.Contains(element);
        }

        // O(1)
        static bool ConstantTimeFind(HashSet<int> array, int element)
        {
            return array.Contains(element);                       
        }

    }
}
