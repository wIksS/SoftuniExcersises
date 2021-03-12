using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Contracts.Strategies
{
    class MergeSorter : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Merge is good but not as fast as quicksort O(n * log(n)");

            return list;
        }
    }
}
