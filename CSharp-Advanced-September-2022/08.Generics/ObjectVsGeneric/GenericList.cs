using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class GenericList
    {
        private object[] internalArray;
        private int index = 0;

        public GenericList()
        {
            internalArray = new object[10];
        }

        public void Add(object element)
        {
            internalArray[index++] = element;
        }

        public object Get(int index)
        {
            return internalArray[index];
        }
    }
}
