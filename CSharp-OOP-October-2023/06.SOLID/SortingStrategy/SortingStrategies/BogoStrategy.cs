using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy.SortingStrategies
{
    public class BogoStrategy : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("BOGO IS NOT USEFUL");

            return list;
        }
    }
}
