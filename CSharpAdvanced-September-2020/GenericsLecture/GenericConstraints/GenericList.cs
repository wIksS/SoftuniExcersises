using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    public class GenericList<T> where T : IComparable<T>
    {
        private T[] array;

        public T GetMax()
        {
            T min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min.CompareTo(array[0]) < 0)
                {
                    min = array[0];
                }
            }

            return min;
        }

    }
}
