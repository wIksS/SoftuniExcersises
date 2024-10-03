
using CustomLinkedListNS;

CustomLinkedList linkedList = new CustomLinkedList();

linkedList.AddLast(5);

linkedList.AddLast(6);

linkedList.AddFirst(4);
linkedList.AddFirst(3);

linkedList.ForEach(n =>
{
    Console.WriteLine(n);
}, true);

int[] array = linkedList.ToArray();

Console.WriteLine($"{string.Join(", ", array)}");

//linkedList.RemoveFirst();

//linkedList.RemoveLast();


//Node node = linkedList.Head;
//while (linkedList.Count > 0 )
//{
//    Console.WriteLine(linkedList.RemoveFirst());
//    //node = node.Next;
//}