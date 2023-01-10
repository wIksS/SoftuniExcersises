using System;
using System.Collections.Generic;

namespace StackVsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine(list[list.Count-1]);
            list.RemoveAt(list.Count - 1);
        }
    }
}
