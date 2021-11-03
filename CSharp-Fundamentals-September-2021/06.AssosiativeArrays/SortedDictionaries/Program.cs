using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SortedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> userAges = new SortedDictionary<int, string>(new IntComparer());

            userAges[31] = "gosho"; 
            userAges[41] = "pepi";
            userAges[51] = "gogi";
            userAges[21] = "pesho"; 

            foreach (var item in userAges)
            {
                Console.WriteLine($"{item.Key}->{item.Value}");          
            }
        }

        class IntComparer : IComparer<int>
        {
            public int Compare([AllowNull] int x, [AllowNull] int y)
            {
                return y- x;
            }
        }
    }
}
