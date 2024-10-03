

LinkedList<string> linkedList = new LinkedList<string>();

for (int i = 0; i < 3; i++)
{
    linkedList.AddLast($"Name{i + 1}");
}

LinkedListNode<string> node = linkedList.First;

 while (node != null)
{
    Console.WriteLine(node.Value);
    node = node.Next;
}