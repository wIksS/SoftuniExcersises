using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.Add(1);
            list.Add(22);
            list.Add(3);
            list.Add(44);
            list.Add(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class MyList<T> : IEnumerable<T>
    {
        private T[] internalArray;
        private int index = 0;
        public MyList()
        {
            internalArray = new T[1000];
        }

        public void Add(T element)
        {
            internalArray[index++] = element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return internalArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}