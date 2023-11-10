using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy.SortingStrategies
{
    public class HeapSort : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Heap sort used and is cool!");
            Console.WriteLine("Without touching existing code!!!");
            list.RemoveAll(t => true);
            list.Add(1);
            return list;
        }
    }
}
