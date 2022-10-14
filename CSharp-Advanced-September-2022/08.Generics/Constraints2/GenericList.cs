using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class GenericList<T> where T : IComparable<T>, IEqualityComparer<T>, new ()
    {
        private T[] internalArray;
        private int index = 0;

        public GenericList()
        {
            internalArray = new T[10];
        }

        public T GetMax()
        {
            
            T max = internalArray[0];
            for (int i = 0; i < internalArray.Length; i++)
            {
                if (max.CompareTo(internalArray[i]) < 0)
                {
                    max = internalArray[i];
                }
            }

            return max;
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
