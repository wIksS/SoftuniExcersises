using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            for (int i = 0; i < 5; i++)
            {
                list.AddHead(new Node(i));
            }

            list.Remove(2);

            list.PrintList();


            Console.WriteLine(list.ToArray().Length);








            //LinkedList list = new LinkedList();

            //for (int i = 0; i < 4; i++)
            //{
            //    list.AddHead(new Node(i));
            //}

            ////list.PrintList();

            ////Console.WriteLine($"Poped: {list.Pop().Value}");
            ////Console.WriteLine($"Poped: {list.Pop().Value}");
            ////Console.WriteLine($"Poped: {list.Pop().Value}");

            ////list.ReversePrintList();


            ////Node currentHead = list.Head;
            ////while (currentHead != null)
            ////{
            ////    Console.WriteLine(currentHead.Value);
            ////    currentHead = currentHead.Next;
            ////}

            //Node head = new Node(0);
            //Node second = new Node(1);
            //head.Next = second;
            //Node third = new Node(2);
            //second.Next = third;
            //Node fourth = new Node(3);
            //third.Next = fourth;


            //Node currentHead = second;
            //while (currentHead != null)
            //{
            //    Console.WriteLine(currentHead.Value);
            //    currentHead = currentHead.Next;
            //}
        }
    }
}
