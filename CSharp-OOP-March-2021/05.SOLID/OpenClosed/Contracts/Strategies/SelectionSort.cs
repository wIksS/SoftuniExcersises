using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Contracts.Strategies
{
    public class SelectionSort : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Selection sort sux O(n^2)");

            return list;
        }
    }
}
