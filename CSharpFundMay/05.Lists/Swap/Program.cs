using System;
using System.Collections.Generic;
using System.Linq;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            string temp = list[from];
            list[from] = list[to];
            list[to] = temp;

            Console.WriteLine(String.Join(",",list));
        }
    }
}
