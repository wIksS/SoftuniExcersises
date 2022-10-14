using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    internal class MyListEnumerator<T> : IEnumerator<T>
    {
        private int count;
        private T[] array;
        private int index = -1;
        public MyListEnumerator(T[] internalArray, int count)
        {
            array = internalArray;
            this.count = count;
        }
        public T Current
        {
            get
            {
                return array[index];
            }
        }
        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++index < count;
        }

        public void Reset()
        {
        }
    }
}
