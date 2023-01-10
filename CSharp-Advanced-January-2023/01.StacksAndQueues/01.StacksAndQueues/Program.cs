using System;
using System.Collections.Generic;

namespace _01.StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int>
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());

            Console.WriteLine($"Stack count: {stack.Count}");
            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack count: {stack.Count}");
            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack count: {stack.Count}");
            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack count: {stack.Count}");
            //Console.WriteLine(stack.Pop());


        }
    }
}
