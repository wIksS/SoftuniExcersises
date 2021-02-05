using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    class ObjectComparer<TFirst, TSecond>
        where TFirst: IComparable
        where TSecond : IComparable
    {
        // 5.CompareTo(6);
        // < -1
        // = 0
        // > 1
        public bool IsFirstBigger(TFirst first, TSecond second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
