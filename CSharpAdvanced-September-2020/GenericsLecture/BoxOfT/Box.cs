using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack;

        public Box()
        {
            stack = new Stack<T>();
        }

        public int Count 
        {
            get
            {
                return stack.Count;
            }
        }

        public void Add(T element)
        {
            stack.Push(element);
        }

        public T Remove()
        {
            return stack.Pop();
        }
    }
}
