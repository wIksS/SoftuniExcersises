using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethods
{
    public class GenericList<T>
    {
        public static bool Contains(List<T> list, T element)
        {
            return list.Contains(element);
        }
    }
}
