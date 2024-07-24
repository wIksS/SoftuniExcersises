using System;
using System.Collections.Generic;

namespace OldTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            int[] array = new int[5];

            List<int> list = new List<int>();

            Console.WriteLine(list.Capacity);
        }
    }
}
