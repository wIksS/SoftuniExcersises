using _02.ImplementLinkedList;
using System;
using System.Text;

namespace StackImplementation
{
    class CoolStack<T>
    {
        private LinkedList<T> linkedList;

        public CoolStack()
        {
            linkedList = new LinkedList<T>();
        }

        public int Count { get { return linkedList.Count; } }

        public void Push(T element)
        {
            linkedList.Add(element);
        }

        public T Peek()
        {
            return linkedList.Head.Value;
        }

        public T Pop()
        {
            return linkedList.RemoveHead().Value;
        }
    }
}
