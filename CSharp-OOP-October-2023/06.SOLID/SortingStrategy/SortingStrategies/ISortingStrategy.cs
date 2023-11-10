using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy.SortingStrategies
{
    public interface ISortingStrategy
    {
        public List<int> Sort(List<int> list);
    }
}
