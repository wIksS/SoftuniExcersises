using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.PrintUniqueNames
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> names = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }

            Console.WriteLine();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
