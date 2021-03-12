using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Contracts.Strategies
{
    class HeapSort : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Heap sort is cool O(n * log(n))");

            return list;
        }
    }
}
