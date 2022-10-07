using System;
using System.Collections.Generic;

namespace ListDownsize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 10000; i++)
            {
                list.Add(i);
                //Console.WriteLine(list.Capacity);
            }

            for (int i = 0; i < 9999; i++)
            {
                list.RemoveAt(0);
                Console.WriteLine(list.Count);
                Console.WriteLine(list.Capacity);
            }
        }
    }
}
