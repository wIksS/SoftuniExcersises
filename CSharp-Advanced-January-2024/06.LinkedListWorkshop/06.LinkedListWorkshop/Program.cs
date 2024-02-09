

LinkedList<int> linkedList = new LinkedList<int>();


linkedList.AddLast(5);
linkedList.AddLast(2);
linkedList.AddLast(1);
linkedList.AddLast(8); 
linkedList.AddLast(3);


LinkedListNode<int> node = linkedList.First;

while (node != null)
{
    Console.WriteLine(node.Value);

    node = node.Next;
}

//foreach (var currentNode in linkedList)
//{
//    Console.WriteLine(currentNode);
//}