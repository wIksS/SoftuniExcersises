using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktorLibrary
{
    public static class Library
    {
        public static List<int> ReadIntListSingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }

        public static void PrintList(List<int> list)
        {
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
