using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumOfNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(nums);

            var command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var splitted = command.Split();
                if (splitted[0] == "add")
                {
                    int firstNumber = int.Parse(splitted[1]);
                    int secondNumber = int.Parse(splitted[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                if (splitted[0] == "remove")
                {
                    int count = int.Parse(splitted[1]);
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

            Console.WriteLine("Sum: " + stack.Sum());
        }
    }
}
