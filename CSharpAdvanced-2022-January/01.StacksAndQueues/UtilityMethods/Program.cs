using System;
using System.Collections.Generic;

namespace UtilityMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4 });
            queue.Enqueue(1);

            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            var array = queue.ToArray();

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            return;


            Stack<string> stack = new Stack<string>();

            stack.Push("pesho");
            stack.Push("gosho");
            stack.Push("hop");

            //string[] array = stack.ToArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Count);
        }
    }
}
