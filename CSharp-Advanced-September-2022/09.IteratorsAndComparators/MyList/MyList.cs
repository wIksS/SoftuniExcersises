using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    internal class MyList<T> : IEnumerable<T>
    {
        private T[] internalArray;
        private int index = 0;
        public MyList()
        {
            internalArray = new T[1000];
        }

        public void Add(T element)
        {
            internalArray[index++] = element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator<T>(internalArray, index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
