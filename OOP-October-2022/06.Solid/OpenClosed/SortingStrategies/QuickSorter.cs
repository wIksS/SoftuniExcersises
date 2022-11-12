using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.SortingStrategies
{
    public class QuickSorter : ISortingStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> data)
        {
            Console.WriteLine("Performing QuickSort!");

            return data;
        }
    }
}
