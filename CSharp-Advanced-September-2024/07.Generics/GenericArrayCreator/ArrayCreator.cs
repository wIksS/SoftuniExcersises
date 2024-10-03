using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int count, T element)
        {
            T[] array = new T[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = element;
            }

            return array;
        }
    }
}
