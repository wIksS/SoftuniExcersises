using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    class GenericNumberConstraint<T>
        where T : struct,
                    IComparable,
                    IComparable<T>,
                    IConvertible,
                    IEquatable<T>,
                    IFormattable
    {
        public void Add(T first, T second)
        {
        }
    }
}
