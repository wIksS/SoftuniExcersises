using System.Collections.Generic;

string input = Console.ReadLine();

Stack<char> stack = new Stack<char>();

foreach (var character in input)
{
    stack.Push(character);
}

while (stack.Count > 0)
{
    Console.Write(stack.Pop());
}