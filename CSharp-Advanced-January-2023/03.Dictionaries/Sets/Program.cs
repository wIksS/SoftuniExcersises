using System;
using System.Collections.Generic;

namespace Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(3);
            set.Add(3);
            set.Add(3);
            set.Add(3);
            set.Add(3);
            set.Add(3);
            set.Add(3);

            set.Remove(3);

            set.Remove(3);            

            Console.WriteLine(set.Contains(2));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
