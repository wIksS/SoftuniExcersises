using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Contracts
{
    public interface ISortingStrategy
    {
        List<int> Sort(List<int> list);
    }
}
