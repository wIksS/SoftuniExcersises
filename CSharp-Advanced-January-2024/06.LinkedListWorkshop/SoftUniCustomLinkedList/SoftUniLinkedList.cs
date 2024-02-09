using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCustomLinkedList
{
    public class SoftUniLinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public int Count { get; set; }

        public void AddLast(int value)
        {
            Count++;
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }

            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }

        public void AddFirst(int value)
        {
            Count++;

            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }

            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }

        public void RemoveFirst()
        {
            Count--;
            Node newHead = Head.Next;

            if (newHead == null)
            {
                Head = null;
                Tail = null;
                return;
            }

            newHead.Previous = null;
            Head.Next = null;
            Head = newHead;
        }

        public void RemoveLast()
        {
            Count--;
            if (Tail == null)
            {
                return;
            }
            Node newTail = Tail.Previous;
            if (newTail == null)
            {
                Head = null;
                Tail = null;
                return;
            }
            newTail.Next = null;
            Tail.Previous = null;

            Tail = newTail;
        }

        public void ForEach(Action<int> callback)
        {
            Node node = Head;

            while (node != null)
            {
                callback(node.Value);
                node = node.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int index = 0;
            Node node = Head;

            while (node != null)
            {
                array[index++] = node.Value;
                node = node.Next;
            }

            return array;
        }
    }
}
