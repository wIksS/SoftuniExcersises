using QueueImplementation;
using System;
using System.Collections.Generic;

namespace CoolQueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CoolQueue<int> queue = new CoolQueue<int>();

            for (int i = 0; i <= 10; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine(queue.Peek());

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
