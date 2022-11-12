using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();

            stackOfStrings.AddRange(new List<string>() { "1", "2", "3", "4", });
            stackOfStrings.AddRange(new List<string>() { "5", "6", "7", "8", });

            while (!stackOfStrings.IsEmpty())
            {
                Console.WriteLine(stackOfStrings.Pop());
            }
        }
    }
}
