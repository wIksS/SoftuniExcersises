using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(5);
            set.Add(5);
            set.Add(5);
            set.Add(5);
            set.Add(3);
            set.Add(7);
            set.Add(2);
            set.Add(1);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
