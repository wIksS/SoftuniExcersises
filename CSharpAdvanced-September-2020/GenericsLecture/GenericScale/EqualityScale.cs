using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T first;
        private T second;

        public EqualityScale(T first, T second)
        {
            this.first = first;
            this.second = second;
        }

        public bool AreEqual()
        {
            return first.Equals(second);
        }
    }
}
