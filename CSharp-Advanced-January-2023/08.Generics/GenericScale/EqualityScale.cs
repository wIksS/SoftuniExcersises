using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T> where T : IComparable<T>
    {
        private T right;
        private T left;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            return left.Equals(right);
        }

        public T GetBigger()
        {
            if (left.CompareTo(right) > 0)
            {
                return left;
            }
            else
            {
                return right;
            }
        }
    }
}
