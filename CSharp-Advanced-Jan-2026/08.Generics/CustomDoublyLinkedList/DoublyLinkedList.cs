using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private int count = 0;

        public ListNode<T> Head { get; set; }

        public ListNode<T> Tail { get; set; }

        public T[] ToArray()
        {
            int index = 0;
            T[] array = new T[count];

            ForeachFromHead((ListNode<T> node) =>
            {
                array[index] = node.Value;
                index++;
            });

            return array;
        }

        public void ForeachFromTail(Action<ListNode<T>> action)
        {
            ListNode<T> currentNode = Tail;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Previous;
            }
        }
        public void Foreach(Action<ListNode<T>> action)
        {
            ForeachFromHead(action);
        }

        public void ForeachFromHead(Action<ListNode<T>> action)
        {
            ListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public void AddFirst(ListNode<T> node)
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

        public void AddLast(ListNode<T> node)
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

        public ListNode<T> RemoveFirst()
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

        public ListNode<T> RemoveLast()
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

        public class ListNode<T>
        {
            public ListNode(T value)
            {
                Value = value;
            }

            public T Value { get; set; }

            public ListNode<T> Next { get; set; }

            public ListNode<T> Previous { get; set; }
        }
    }
}
