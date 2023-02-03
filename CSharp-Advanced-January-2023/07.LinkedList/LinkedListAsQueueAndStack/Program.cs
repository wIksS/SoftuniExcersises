
LinkedList<int> stack = new LinkedList<int>();

stack.AddFirst(1);
stack.AddFirst(2);
stack.AddFirst(3);
stack.AddFirst(4);
stack.AddFirst(5);


while (stack.Count > 0)
{
    int value = stack.First.Value;
    stack.RemoveFirst();

    Console.WriteLine(value);
}

LinkedList<int> queue = new LinkedList<int>();

stack.AddLast(1);
stack.AddLast(2);
stack.AddLast(3);
stack.AddLast(4);
stack.AddLast(5);


while (stack.Count > 0)
{
    // queue dequeue
    int value = stack.First.Value;
    stack.RemoveFirst();
    Console.WriteLine(value);
}