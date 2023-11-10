using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy
{
    public class SorterWithoutOCP
    {
        private List<int> list;

        public SorterWithoutOCP(List<int> list)
        {
            this.list = list;
        }

        public List<int> SelectionSort()
        {
            //
            //
            //
            //
            Console.WriteLine("Selection sort used!");
            return list;
        }

        public List<int> BubbleSort()
        {
            //
            //
            //
            //
            Console.WriteLine("Bubble sort used!");
            return list;
        }


    }
}
