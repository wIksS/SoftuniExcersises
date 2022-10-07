using System;
using System.Collections.Generic;
using System.Text;

namespace SoftuniLinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public bool IsReversed { get; set; }

        public void Reverse()
        {
            IsReversed = !IsReversed;
            var oldhead = Head;
            Head = Tail;
            Tail = oldhead;
        }

        public void AddFirst(Node node)
        {

            Count++;

            if (Tail == null)
            {
                Tail = node;
                Head = node;
                return;
            }

            if (IsReversed)
            {
                Head.Next = node;
                node.Previous = Head;
                Head = node;
            }
            else
            {
                Head.Previous = node;
                node.Next = Head;
                Head = node;
            }


        }

        public void AddFirst(int value)
        {
            AddFirst(new Node(value));
        }


        public void AddLast(Node node)
        {
            Count++;

            if (Head == null)
            {
                Tail = node;
                Head = node;
                return;
            }

            if (IsReversed)
            {
                Tail.Previous = node;
                node.Next = Tail;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }

        }

        public void AddLast(int value)
        {
            AddLast(new Node(value));
        }

        public int RemoveFirst()
        {
            Node oldHead = Head;
            Head = Head.Next;
            Head.Previous = null;
            oldHead.Next = null;

            return oldHead.Value;
        }

        public int RemoveLast()
        {
            Node oldTail = Tail;
            Tail = Tail.Previous;
            Tail.Next = null;
            oldTail.Previous = null;

            return oldTail.Value;
        }

        public void ForEach(Action<int> callback)
        {
            Node node = Head;

            while (node != null)
            {
                callback(node.Value);
                if (IsReversed)
                {
                    node = node.Previous;
                }
                else
                {
                    node = node.Next;
                }
            }
        }

        public void ForEachReverse(Action<int> callback)
        {
            Node node = Tail;
            while (node != null)
            {
                callback(node.Value);
                node = node.Previous;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int index = 0;
            ForEach(n =>
            {
                array[index++] = n;
            });

            return array;
        }
    }
}
