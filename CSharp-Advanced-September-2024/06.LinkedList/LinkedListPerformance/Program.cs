Stack<int> stack = new Stack<int>();

LinkedList<int> linkedListStack = new LinkedList<int>();

//stack.Push(1);
//stack.Push(2);
//stack.Push(3);
//stack.Push(4);
//stack.Push(5);


//while (stack.Count > 0)
//{
//    Console.WriteLine(stack.Pop());
//}

linkedListStack.AddFirst(1);
linkedListStack.AddFirst(2);
linkedListStack.AddFirst(3);
linkedListStack.AddFirst(4);
linkedListStack.AddFirst(5);

LinkedListNode<int> node = linkedListStack.First;

while (linkedListStack.Count > 0)
{
    Console.WriteLine(node.Value);
    node = node.Next;
    linkedListStack.RemoveFirst();
}