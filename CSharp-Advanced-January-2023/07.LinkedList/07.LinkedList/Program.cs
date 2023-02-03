LinkedList<int> linkedList = new LinkedList<int>();

linkedList.AddFirst(1);
linkedList.AddFirst(2);
linkedList.AddFirst(3);

linkedList.AddLast(4);
linkedList.AddLast(5);
linkedList.AddLast(6);

linkedList.RemoveFirst();

linkedList.RemoveLast();


Console.WriteLine("From HEAD to TAIL: ");
LinkedListNode<int> node = linkedList.First;

while (node != null)
{
    Console.WriteLine(node.Value);
    node = node.Next;
}

Console.WriteLine("From TAIL to HEAD: ");
node = linkedList.Last;

while (node != null)
{
    Console.WriteLine(node.Value);
    node = node.Previous;
}

//foreach (var currentNode in linkedList)
//{
//    Console.WriteLine(currentNode);
//}