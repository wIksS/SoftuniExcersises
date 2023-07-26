using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableNS
{
    internal abstract class Shape : ICloneable
    {
        public abstract object Clone();
    }
}
