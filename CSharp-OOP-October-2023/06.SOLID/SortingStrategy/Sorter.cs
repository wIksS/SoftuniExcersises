using SortingStrategy.SortingStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy
{
    public class Sorter
    {
        private ISortingStrategy strategy;
        private List<int> list;

        public Sorter(ISortingStrategy strategy, List<int> list)
        {
            this.strategy = strategy;
            this.list = list;
        }

        public List<int> Sort()
        {
            Console.WriteLine("Starting sort");
            list = strategy.Sort(list);

            Console.WriteLine($"{string.Join(",", list)}");

            return list;
        }
    }
}
