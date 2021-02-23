using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings<string> stack = new StackOfStrings<string>();

            Console.WriteLine(stack.IsEmpty());

            stack.AddRange(new List<string>()
            {
                "123",
                "456",
                "789",
                "Gogi"
            });

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
