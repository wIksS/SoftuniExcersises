

Stack<int> stack = new Stack<int>();

stack.Pop();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}