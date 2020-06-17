using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveAt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nullList = new List<string>();
            Console.WriteLine(nullList[0]);
            List<string> list = Console.ReadLine().Split().ToList();

            while (list.Count != 0)
            {
                list.RemoveAt(0);
                Console.WriteLine(String.Join(",", list));
            }

        }
    }
}
