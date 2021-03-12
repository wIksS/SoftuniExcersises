using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Contracts.Strategies
{
    public class QuickSort : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Quick sort O(n * log(n) (best case ) worst case O(n^ 2))");

            return list;
        }
    }
}
