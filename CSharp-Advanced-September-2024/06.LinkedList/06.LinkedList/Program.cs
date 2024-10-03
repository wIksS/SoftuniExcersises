

LinkedList<int> linkedList = new LinkedList<int>();

linkedList.AddLast(5);
linkedList.AddLast(3);
linkedList.AddLast(7);

LinkedListNode<int> node = linkedList.First;

Console.WriteLine(node.Value);

Console.WriteLine(node.Next.Value);
LinkedListNode<int> lastNode = node.Next.Next;

Console.WriteLine(lastNode.Value);

