using System;
using System.Collections;

namespace CustomStack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> list;

        public Stack()
        {
            list = new List<T>();
        }

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            T last = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return last;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}