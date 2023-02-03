using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class SoftuniLinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public int Count { get; set; }

        public void AddFirst(int value)
        {
            Count++;
            Node node = new Node(value);

            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.Next = Head;
            Head.Previous = node;
            Head = node;
        }

        public void AddLast(int value)
        {
            Count++;
            Node node = new Node(value);
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;
        }

        public void RemoveFirst()
        {
            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
            }

            Node oldHead = Head;

            Head = Head.Next;

            oldHead.Next = null;
            Head.Previous = null;
            Count--;
        }

        public void RemoveLast()
        {
            if (Tail.Previous == null)
            {
                Tail = null;
                Head = null;
            }
            Node oldTail = Tail;
            Tail = Tail.Previous;

            oldTail.Previous = null;
            Tail.Next = null;
            Count--;
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int i = 0;
            ForEach(e => array[i++] = e);

            return array;
        }

        public void ForEach(Action<int> callback)
        {
            Node current = Head;

            while (current != null)
            {
                callback(current.Value);
                current = current.Next; 
            }
        }

        public void ForEachReversed(Action<int> callback)
        {
            Node current = Tail;

            while (current != null)
            {
                callback(current.Value);
                current = current.Previous;
            }
        }
    }
}
