using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoublyLinkedList<T>
    {
        private bool IsReversed = false;

        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int Count { get; set; }

        public void Reverse()
        {
            IsReversed = !IsReversed;
        }

        public void ForEach(Action<Node<T>> action)
        {
            var node = Head;
            if (IsReversed)
            {
                node = Tail;
            }
            while (node != null)
            {
                action(node);
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

        public Node<T>[] ToArray()
        {
            Node<T>[] array = new Node<T>[Count];
            var node = Head;
            int index = 0;
            while (node != null)
            {
                array[index++]=node;
                node = node.Next;
            }

            return array;
        }

        public Node<T> RemoveFirst()
        {
            if (Head == null)
            {
                return null;
            }
            Count--;

            var previous = Head;
            var next = Head.Next;
            if (next != null)
            {
                next.Previous = null;
            }
            else
            {
                Tail = null;
            }
            Head = next;

            return previous;
        }

        public Node<T> RemoveLast()
        {
            if (Tail == null)
            {
                return null;
            }
            Count--;

            var previous = Tail;
            var next = Tail.Previous;
            if (next != null)
            {
                next.Next = null;
            }
            else
            {
                Head = null;
            }
            Tail = next;

            return previous;
        }

        public void AddFirst(Node<T> node)
        {
            Count++;
            // check if first element is added to linked list
            if (!ChekIfFirstElementInList(node))
            {
                Node<T> previousHead = Head;
                Head = node;
                previousHead.Previous = Head;
                Head.Next = previousHead;
            }
        }

        public void AddLast(Node<T> node)
        {
            Count++;

            // check if first element is added to linked list
            if (!ChekIfFirstElementInList(node))
            {
                Node<T> previousTail = Tail;
                Tail = node;
                previousTail.Next = Tail;
                Tail.Previous = previousTail;
            }
        }

        private bool ChekIfFirstElementInList(Node<T> node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return true;
            }

            return false;
        }
    }
}
