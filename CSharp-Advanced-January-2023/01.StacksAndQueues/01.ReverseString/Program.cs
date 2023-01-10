using System;
using System.Collections.Generic;

namespace _01.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var character in input)
            {
                stack.Push(character);
            }

            //Console.WriteLine(stack.Count);

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

            //Console.WriteLine(String.Join("", stack));
        }
    }
}
