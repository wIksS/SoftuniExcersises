using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SoftuniLinkedList;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 10000000;
            int reverse = 100000000;
            Stopwatch watch = new Stopwatch();

            List<int> list = new List<int>();
            int num = 0;

            for (int i = 0; i < count; i++)
            {
                list.Add(num++);
            }
            watch.Start();

            //for (int i = 0; i < reverse; i++)
            //{
            //    list.Reverse();
            //}

            Console.WriteLine(watch.ElapsedMilliseconds);

            watch = new Stopwatch();

            LinkedList linkedList = new LinkedList();
            num = 0;

            for (int i = 0; i < count; i++)
            {
                linkedList.AddLast(num++);
            }
            watch.Start();

            for (int i = 0; i < reverse; i++)
            {
                linkedList.Reverse();
            }
            Console.WriteLine(watch.ElapsedMilliseconds);

            watch = new Stopwatch();

            LinkedList<int> linkedList2 = new LinkedList<int>();
            num = 0;

            for (int i = 0; i < count; i++)
            {
                linkedList2.AddLast(num++);
            }
            watch.Start();

            for (int i = 0; i < reverse; i++)
            {
                linkedList2.Reverse();
            }

            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
