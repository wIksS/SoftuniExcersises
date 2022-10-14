using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class GenericList<T>
    {
        private T[] internalArray;
        private int index = 0;

        public GenericList()
        {
            internalArray = new T[10];
        }

        public void Add(T element)
        {
            internalArray[index++] = element;
        }

        public T Get(int index)
        {
            return internalArray[index];
        }
    }
}
