using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> list;

        public Box()
        {
            list = new Stack<T>();
        }

        public void Add(T element)
        {
            list.Push(element);
        }

        public T Remove()
        {
            return list.Pop();
        }

        public int Count { get { return list.Count; } }
    }
}
