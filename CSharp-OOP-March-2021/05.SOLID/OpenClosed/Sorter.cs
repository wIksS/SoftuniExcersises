using OpenClosed.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public class Sorter
    {
        private ISortingStrategy sortingStrategy;

        public Sorter(ISortingStrategy sortingStrategy)
        {
            this.sortingStrategy = sortingStrategy;
        }

        public List<int> Sort(List<int> list)
        {
            return sortingStrategy.Sort(list);
        }
    }
}
