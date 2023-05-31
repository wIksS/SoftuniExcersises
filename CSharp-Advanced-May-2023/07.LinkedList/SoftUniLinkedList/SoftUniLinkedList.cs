using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLinkedList
{
    public class CustomLinkedList
    {
        private bool isReversed = false;
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int Count { get; set; }

        public void Reverse()
        {
            var oldHead = Head;
            Head = Tail;
            Tail = oldHead;

            isReversed = !isReversed;
        }

        public void ForEach(Action<Node> action)
        {
            Node node = Head;

            while (node != null)
            {
                action(node);
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
                array[index++] = n.Value;
            });

            return array;
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

            Tail.Next = node;

            node.Previous = Tail;
            Tail = node;
        }

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

            Head.Previous = node;
            node.Next = Head;
            Head = node;
        }

        public void Push(int value)
        {
            AddFirst(value);
        }
        public Node Pop()
        {
            return RemoveFirst();
        }

        public Node Peek()
        {
            return Head;
        }

        public Node RemoveFirst()
        {
            if (Head == null)
            {
                return null;
            }

            Count--;
            Node oldHead = Head;
            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
                return oldHead;
            }
            // 2 3 4 5
            Node newHead = Head.Next;
            Head.Next = null;
            newHead.Previous = null;
            Head = newHead;

            return oldHead;
        }

        public Node RemoveLast()
        {
            if (Tail == null)
            {
                return null;
            }

            Count--;
            Node oldTail = Tail;
            if (Tail.Previous == null)
            {
                Head = null;
                Tail = null;
                return oldTail;
            }

            Node newTail = Tail.Previous;
            Tail.Previous = null;
            newTail.Next = null;
            Tail = newTail;

            return oldTail;
        }
    }
}
