using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 11, 2, 33, 4 };

            list = list.OrderByDescending(x => x).ToList();

            Console.WriteLine(String.Join(" ", list));
            //Console.WriteLine(String.Join(" ", newList));
        }
    }
}
