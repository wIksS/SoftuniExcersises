using System;
using System.Collections.Generic;
using System.Text;

namespace _02.ImplementLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Last { get; set; }
        public int Count { get; set; }

        public void Add(T element)
        {
            Node<T> newHead = new Node<T>(element);
            newHead.Next = Head;
            if (Head == null)
            {
                Last = newHead;
            }

            Head = newHead;
            Count++;
        }

        public void AddLast(T element)
        {
            Node<T> newLast = new Node<T>(element);
            if (Last == null)
            {
                Last = newLast;
                Head = newLast;
            }
            else
            {
                Last.Next = newLast;
                Last = newLast;
            }
            Count++;
        }

        public Node<T> RemoveHead()
        {
            var oldHead = Head;
            Head = Head.Next;

            if (Head == null)
            {
                Last = null;
            }
            if (Count > 0)
            {
                Count--;
            }

            return oldHead;
        }
    }
}
