

Stack<int> stack = new Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

int element = stack.Pop();

Console.WriteLine(element);

Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Peek());
