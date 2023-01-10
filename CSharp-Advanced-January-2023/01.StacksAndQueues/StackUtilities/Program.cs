using System;
using System.Collections.Generic;
using System.Linq;

namespace StackUtilities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Count);

            Console.WriteLine(stack.Contains(2));
            Console.WriteLine(stack.Contains(22));

            int[] array = stack.ToArray();
            List<int> list = stack.ToList();

            Console.WriteLine(String.Join(" ", array));

            stack.TrimExcess();
        }
    }
}
