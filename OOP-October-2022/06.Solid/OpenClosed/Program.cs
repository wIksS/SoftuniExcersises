using System;
using System.Collections.Generic;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What strategy do you want?");

            string strategy = Console.ReadLine();

            Sorter sorter = new Sorter(strategy);

            sorter.Sort(new List<int>());
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
