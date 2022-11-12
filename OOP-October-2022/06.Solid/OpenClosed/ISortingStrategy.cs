using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public interface ISortingStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> data);
    }
}
