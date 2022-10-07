using System;

namespace SoftuniLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(3);
            list.AddFirst(4);

            //list.RemoveFirst();
            //list.RemoveLast();

            Console.WriteLine(String.Join(",", list.ToArray()));


            list.Reverse();
            Console.WriteLine("Reverse!!!");

            Console.WriteLine(String.Join(",", list.ToArray()));
            list.AddFirst(0);
            list.AddLast(55);
            list.Reverse();
            list.AddFirst(-1);
            list.AddLast(56);
            Console.WriteLine(String.Join(",", list.ToArray()));

            list.Tail.Next = list.Head;

            list.ForEach(n => Console.WriteLine(n));

        }
    }
}
