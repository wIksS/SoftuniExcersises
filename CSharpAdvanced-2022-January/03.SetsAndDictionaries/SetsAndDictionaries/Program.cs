using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> studentNumbers = new SortedDictionary<int, string>(new NumbersComparer());

            studentNumbers.Add(13, "Peshkata");
            studentNumbers.Add(12, "Dimitrichko");
            studentNumbers.Add(3, "Gogi");

            studentNumbers.Add(24, "Bobi");

            studentNumbers.Add(3, "Dobi");
            studentNumbers =  new SortedDictionary<int, string>(studentNumbers.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value));

            foreach (var studentNumber in studentNumbers)
            {
                Console.WriteLine($"{studentNumber.Key} -> {studentNumber.Value}");
            }
        }
    }

    class NumbersComparer : IComparer<int>
    {
        public int Compare([AllowNull] int x, [AllowNull] int y)
        {
            return y % 2 == 0 ?1:-1;
        }
    }

    class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.CompareTo(y);
        }
    }
}
