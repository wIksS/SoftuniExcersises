
LinkedList<int> linkedList = new LinkedList<int>();

linkedList.AddLast(10);
linkedList.AddLast(20);
linkedList.AddLast(30);
linkedList.AddLast(40);


Console.WriteLine(linkedList.First.Value);
Console.WriteLine(linkedList.Last.Value);

LinkedListNode<int> currentNode = linkedList.First;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Next;
}