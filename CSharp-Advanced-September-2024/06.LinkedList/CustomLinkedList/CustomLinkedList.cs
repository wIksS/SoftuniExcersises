using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedListNS
{
    public class CustomLinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public int Count { get; set; }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);

            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }

            Count++;
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Head.Previous = newNode;
                newNode.Next = Head;
                Head = newNode;
            }           

            Count++;
        }

        public int RemoveFirst()
        {
            Node oldHead = Head;
            Count--;

            if (Head.Next == null)
            {
                Head = null;
                Tail = null;

                return oldHead.Value;
            }

            Head = Head.Next;

            Head.Previous = null;
            oldHead.Next = null;

            return oldHead.Value;
        }

        public int RemoveLast()
        {
            Node oldTail = Tail;
            Count--;

            if (Tail.Previous == null)
            {
                Head = null;
                Tail = null;

                return oldTail.Value;
            }

            Tail = Tail.Previous;

            Tail.Next= null;
            oldTail.Previous = null;

            return oldTail.Value;
        }

        public void ForEach(Action<int> action, bool isReversed = false)
        {
            Node node = null;

            if (isReversed)
            {
                node = Tail;
            }
            else
            {
                node = Head;
            }

            while (node != null)
            {
                action(node.Value);

                if (isReversed)
                {
                    node = node.Previous;
                }
                else
                {
                    node = node.Next;
                }
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
