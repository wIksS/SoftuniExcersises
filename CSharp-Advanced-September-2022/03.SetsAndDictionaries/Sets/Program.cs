using System;
using System.Collections.Generic;

namespace Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> "3123121fds1"
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);

            set.Add(5);
            set.Add(5);

            Console.WriteLine(string.Join(",", set));

            Console.WriteLine(set.Contains(3));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
