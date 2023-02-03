using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class CustomList<T>
    {
        private T[] internalArray;

        public CustomList()
        {
            internalArray = new T[8];
        }

        public T FindElement(T element)
        {
            return internalArray.FirstOrDefault(e => e.Equals(element));
        }
    }
}
