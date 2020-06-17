using System;
using System.Collections.Generic;
using System.Linq;

namespace ListMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            PrintList(list);
            if (list.Remove("pesho"))
            {
                Console.WriteLine("Removed pesho!!!");
            }
            else
            {
                Console.WriteLine("no pesho found :(");
            }

            while (list.Remove("gosho")) { }

            Console.WriteLine("-----------");
            PrintList(list);
        }

        static void PrintList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"List[{i}]={list[i]}");
            }
        }
    }
}
