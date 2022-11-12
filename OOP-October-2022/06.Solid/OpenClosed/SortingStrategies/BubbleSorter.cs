using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public class BubbleSorter : ISortingStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> data)
        {
            Console.WriteLine("Performing Bubble Sort!");

            return data;
        }
    }
}
