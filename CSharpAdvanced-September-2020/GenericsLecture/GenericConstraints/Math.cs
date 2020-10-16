using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    class Math<T> where T : struct,
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
    {
        public T Max(T first, T second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

    }
}
