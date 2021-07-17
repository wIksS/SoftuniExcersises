using System;
using System.Collections.Generic;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var integerHeap = new Heap<int>();
            var elements = new List<int>() {4,3,5,1, 1, 6, 9, 5, 5, 8, 1, 1, 5, 1, 1, 6, 9, 5, 5, 8, 1, 1, 5, 1, 1, 6, 9, 5, 5, 8, 1, 1, 5, 1, 1, 6, 9, 5, 5, 8, 1, 1, 5, 1, 1, 6, 9, 5, 5, 8, 1, 1, 5, 1, 1, 6, 9, 5, 5, 8, 1, 1,5,1, 1, 6, 9, 5, 5, 8, 1, 1 };
            foreach (var el in elements)
            {
                integerHeap.Add(el);

            }
            //Console.WriteLine(integerHeap.DFSInOrder(0, 0));
            //Console.WriteLine("\n");

            var queue = new PriorityQueue<int>();
            elements = new List<int>() { 15, 25, 6, 9, 5, 8, 17, 16 };
            foreach (var element in elements)
            {
                queue.Add(element);
            }

            while (queue.Size > 0)
            {
                Console.WriteLine(queue.DFSInOrder(0, 0));
                Console.WriteLine($"Max element: {queue.Deqeueue()}");
            }

        }
    }
}
