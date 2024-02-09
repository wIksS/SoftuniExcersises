

using SoftUniCustomLinkedList;

SoftUniLinkedList linkedList = new SoftUniLinkedList();

linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddFirst(0);
linkedList.AddFirst(-1);

linkedList.ForEach(n =>
{
    Console.WriteLine(n);
});

int[] array = linkedList.ToArray();

Console.WriteLine(String.Join(",", array));
//linkedList.RemoveFirst();

//linkedList.RemoveLast();
//linkedList.RemoveLast();
//linkedList.RemoveLast();
//linkedList.RemoveLast();

//Node node = linkedList.Head;

//while (node != null)
//{
//    Console.WriteLine(node.Value);
//    node = node.Next;
//}
