using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    class CustomList<T>
    {
        private T[] internalArray;
        private int index = 0;
        private int resizeNumber = 0;
        public CustomList(int capacity = 8)
        {
            internalArray = new T[capacity];
        }

        public T this[int index]
        {
            get { return internalArray[index]; }
        }

        public void Add(T value)
        {
            if (index >= internalArray.Length)
            {
                Resize();
            }

            internalArray[index++] = value;
        }

        public void RemoveAt(int index)
        {

        }

        private void Resize()
        {
            resizeNumber++;
            //Console.WriteLine($"Resized: {resizeNumber}");
            T[] newArray = new T[internalArray.Length * 4];

            for (int i = 0; i < internalArray.Length; i++)
            {
                newArray[i] = internalArray[i];
            }

            internalArray = newArray;
        }
    }
}
