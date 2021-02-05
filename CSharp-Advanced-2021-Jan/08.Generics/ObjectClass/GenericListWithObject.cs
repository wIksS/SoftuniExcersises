using System;
using System.Collections.Generic;

namespace ObjectClass
{
    class GenericListWithObject
    {
        private object[] array = new object[10];
        private int index = 0;

        public void Add(object element)
        {
            array[index] = element;
            index++;
        }

        public object GetAt(int position)
        {
            return array[position];
        }

        public object this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
