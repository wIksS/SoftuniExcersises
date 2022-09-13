using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(String.Join(",",stack));
            Console.WriteLine(stack.Contains(1));
            Console.WriteLine($"Count : {stack.Count} ");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            return;
            //3
            //2
            //1
            int firstElement = stack.Pop();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            // Console.WriteLine($"First element is: {stack.Pop()}");

            //2
            //1

            //Console.WriteLine($"First element is: {stack.Pop()}");


        }


    }
}
