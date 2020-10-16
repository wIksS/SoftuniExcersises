using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasses
{
    class ObjectList
    {
        private object[] internalArray;
        private int index = 0;

        public ObjectList()
        {
            internalArray = new object[8];
        }

        public void Add(object newElement)
        {
            internalArray[index] = newElement;
            index++;
            if (index == internalArray.Length)
            {
                // resize
            }
        }
    }
}
