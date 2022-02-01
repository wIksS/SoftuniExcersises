using System;
using System.Collections.Generic;

namespace SortedSets
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>();
            set.Add(5);
            set.Add(5);
            set.Add(5);
            Console.WriteLine("Sorted");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            set.Add(5);
            Console.WriteLine("Sorted");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            set.Add(3);
            Console.WriteLine("Sorted");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            set.Add(7);
            Console.WriteLine("Sorted");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            set.Add(2);
            Console.WriteLine("Sorted");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            set.Add(1);

            Console.WriteLine("Sorted");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
