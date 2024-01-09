

Stack<int> stack = new Stack<int>();

stack.Push(5);
stack.Push(16);
stack.Push(27);
stack.Push(38);
stack.Push(49);

//int topElement = stack.Pop();

//Console.WriteLine(topElement);

//Console.WriteLine(stack.Pop());

while (stack.Count != 0)
{
    int topElement = stack.Pop();

    Console.WriteLine(topElement);
}

Console.WriteLine(stack.Pop());