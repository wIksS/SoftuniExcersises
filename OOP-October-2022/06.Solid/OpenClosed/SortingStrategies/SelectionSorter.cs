using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public class SelectionSorter : ISortingStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> data)
        {
            Console.WriteLine("Performing Selection Sort!");

            return data;
        }
    }
}
