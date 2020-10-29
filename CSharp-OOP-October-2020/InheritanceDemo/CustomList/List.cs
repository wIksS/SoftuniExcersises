using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    class List<T> : IEnumerable<T>
    {
        private T[] array;
        private int index = 0;

        public List()
        {
            array = new T[20];
        }

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public virtual void Add(T element)
        {
            array[index++] = element;
        }

        public T Get(int i)
        {
            return array[i];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
