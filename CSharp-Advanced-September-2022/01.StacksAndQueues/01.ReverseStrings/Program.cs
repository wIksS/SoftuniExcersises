using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char character in input)
            {
                stack.Push(character);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            //xyz

            //z
            //y
            //x

        }
    }
}
