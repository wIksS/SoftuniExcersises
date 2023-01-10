using System;
using System.Collections.Generic;

namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3 };
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int topElement = stack.Pop();
            topElement = stack.Peek();
            //int listElement = list[0];
        }
    }
}
