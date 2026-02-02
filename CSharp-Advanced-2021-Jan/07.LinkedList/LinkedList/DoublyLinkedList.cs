using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private int count = 0;

        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public T[] ToArray()
        {
            int index = 0;
            T[] array = new T[count];

            ForeachFromHead((Node<T> node) =>
            {
                array[index] = node.Value;
                index++;
            });

            return array;
        }

        public void ForeachFromTail(Action<Node<T>> action)
        {
            Node<T> currentNode = Tail;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Previous;
            }
        }

        public void ForeachFromHead(Action<Node<T>> action)
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public void AddHead(Node<T> node)
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

        public void AddLast(Node<T> node)
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

        public Node<T> RemoveHead()
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

        public Node<T> RemoveTail()
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
