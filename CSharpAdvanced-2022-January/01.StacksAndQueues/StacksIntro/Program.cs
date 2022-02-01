using System;
using System.Collections.Generic;

namespace StacksIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack cound: {stack.Count}");
            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack cound: {stack.Count}");

            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack cound: {stack.Count}");

            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack cound: {stack.Count}");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


        }
    }
}
