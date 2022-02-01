using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var splittedCommand = command.Split();
                if (splittedCommand[0] == "add")
                {
                    int first = int.Parse(splittedCommand[1]);
                    int second = int.Parse(splittedCommand[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                if (splittedCommand[0] == "remove")
                {
                    int count = int.Parse(splittedCommand[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            int sum = 0;
            while (stack.Count>0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
