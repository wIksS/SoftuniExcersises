using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLists
{
    public class ObjectList
    {
        private object[] internalArray;
        private int index = 0;
        public ObjectList()
        {
            internalArray = new object[100];
        }

        public void Add(object element)
        {
            internalArray[index++] = element;
        }

        public object GetElement(int index)
        {
            return internalArray[index];
        }
    }

    public class GenericList<T>
    {
        private T[] internalArray;
        private int index = 0;

        public GenericList()
        {
            internalArray = new T[100];
        }

        public void Add(T element)
        {
            internalArray[index++] = element;
        }
    }
}
