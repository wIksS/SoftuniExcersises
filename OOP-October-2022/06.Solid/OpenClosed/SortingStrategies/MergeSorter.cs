using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public class MergeSorter : ISortingStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> data)
        {
            Console.WriteLine("Performing Merge Sort!");

            return data;
        }
    }
}
