using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class SoftuniLinkedList
    {
        private int count = 0;

        public Node Head { get; set; }

        public Node Tail { get; set; }

        public int[] ToArray()
        {
            int index = 0;
            int[] array = new int[count];

            ForeachFromHead((Node node) =>
            {
                array[index] = node.Value;
                index++;
            });

            return array;
        }

        public void ForeachFromTail(Action<Node> action)
        {
            Node currentNode = Tail;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Previous;
            }
        }

        public void ForeachFromHead(Action<Node> action)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public void AddHead(Node node)
        {
            count++;
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

        public void AddLast(Node node)
        {
            count++;
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

        public Node RemoveHead()
        {
            if (Head == null)
            {
                return null;
            }

            count--;

            var nodeToReturn = Head;
            if (Head.Next != null)
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }

            return nodeToReturn;
        }

        public Node RemoveTail()
        {
            if (Tail == null)
            {
                return null;
            }

            count--;
            var nodeToReturn = Tail;
            if (Tail.Previous != null)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                Tail = null;
                Head = null;
            }

            return nodeToReturn;
        }
    }
}
