using System;
using System.Collections.Generic;
using System.Text;

namespace _06.LinkedList
{
    public class SoftuniLinkedLIst
    {
        public Node Head { get; set; }

        public int Count { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(Node node)
        {
            if (Tail == null)
            {
                Tail = node;
                Head = node;
                return;
            }

            Head.Previous = node;

            node.Next = Head;
            Count++;

            Head = node;
        }

        public void AddFirst(int value)
        {
            AddFirst(new Node(value));
        }

        public void AddLast(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            Tail.Next = node;
            Tail = node;
        }

        public int RemoveFirst()//pop
        {
            Count--;
            int oldHead = Head.Value;
            Head = Head.Next;
            if (Head == null)
            {
                Tail = null;
            }

            return oldHead;
        }

        public int RemoveLast()//pop
        {
            Count--;
            int oldHead = Head.Value;
            Head = Head.Next;
            return oldHead;
        }
    }
}
