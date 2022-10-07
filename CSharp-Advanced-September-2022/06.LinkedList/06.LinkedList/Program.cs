using System;
using System.Collections.Generic;

namespace _06.LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackWithLinkedList stack = new StackWithLinkedList();
            stack.Add(1);
            stack.Add(2);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            return;


            SoftuniLinkedLIst linkedList = new SoftuniLinkedLIst();

            linkedList.AddFirst(new Node(1));
            linkedList.AddFirst(new Node(2));
            linkedList.AddFirst(new Node(3));
            linkedList.AddFirst(new Node(4));

            while (linkedList.Count > 0)
            {
                Console.WriteLine(linkedList.RemoveFirst());
            }

            Console.WriteLine(linkedList.RemoveFirst());

            //Node currentNode = linkedList.Head;

            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Next;
            //}
        }
    }
}
