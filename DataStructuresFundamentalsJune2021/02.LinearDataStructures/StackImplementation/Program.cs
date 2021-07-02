using System;
using System.Collections.Generic;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CoolStack<int> stack = new CoolStack<int>();

            for (int i = 0; i <= 10; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine(stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
