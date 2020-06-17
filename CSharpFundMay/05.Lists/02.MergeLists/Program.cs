using System;
using System.Collections.Generic;
using System.Linq;
using ViktorLibrary;

namespace _02.MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = ViktorLibrary.Library.ReadIntListSingleLine();
            var secondList = ViktorLibrary.Library.ReadIntListSingleLine();

            Console.WriteLine(String.Join(" ", MergeLists(firstList, secondList)));

        }

        static List<int> MergeLists(List<int> first, List<int> second)
        {
            int count = Math.Max(first.Count, second.Count);
            List<int> merged = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (first.Count > i)
                {
                    merged.Add(first[i]);
                }
                if (second.Count > i)
                {
                    merged.Add(second[i]);
                }
            }

            return merged;
        }
    }
}
