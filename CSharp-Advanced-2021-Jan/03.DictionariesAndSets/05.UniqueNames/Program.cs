using System;
using System.Collections.Generic;

namespace _05.UniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> names = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
