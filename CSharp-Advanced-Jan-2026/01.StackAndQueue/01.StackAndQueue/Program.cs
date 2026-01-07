
List<int> list;
Stack<int> stack = new Stack<int>();


stack.Push(1);
stack.Push(5);
stack.Push(-3);
stack.Push(32);

foreach (var item in stack)
{
    Console.WriteLine(item);
}

Console.WriteLine(stack.Count);


//Console.WriteLine(firstElement);

//Console.WriteLine($"Stack count after pop: {stack.Count}");

//Console.WriteLine(stack.Peek());

//Console.WriteLine();