
List<int> list = new List<int>();

Console.WriteLine(list[555]);
Stack<int> stack = new Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);

// LIFO

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());


Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());

Console.WriteLine($"Count: {stack.Count}");

