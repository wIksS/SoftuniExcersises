using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedSortingStrategy.Strategies
{
    public interface ISortingStrategy
    {
        List<T> Sort<T>(List<T> list);
    }
}
