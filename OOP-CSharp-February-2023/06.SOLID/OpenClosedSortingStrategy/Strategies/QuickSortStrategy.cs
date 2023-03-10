using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedSortingStrategy.Strategies
{
    public class QuickSortStrategy : ISortingStrategy
    {
        public List<T> Sort<T>(List<T> list)
        {
            Console.WriteLine("Quick sorting");

            return list;
        }
    }
}
