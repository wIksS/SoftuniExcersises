
using CustomLinkedList;

SoftuniLinkedList linkedList = new SoftuniLinkedList();

linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);

linkedList.AddFirst(51);

//linkedList.RemoveFirst();
//linkedList.RemoveLast();

int[] arr = linkedList.ToArray();

Console.WriteLine(String.Join(",",arr));

linkedList.ForEach(x =>
{
    Console.WriteLine($"Node: {x}");
});

Console.WriteLine("Reversed");

linkedList.ForEachReversed(x =>
{
    Console.WriteLine($"Node: {x}");
});

//Node node = linkedList.Head;

//while (node != null)
//{
//    Console.WriteLine(node.Value);
//    node = node.Next;
//}

//Node head = new Node(1);

//head.Next = new Node(2);

//head.Next.Next = head;

//head.Next.Next.Next.Next.Next.Next.Next.Next.Next = new Node(3); 

//node = head;

//while (node != null)
//{
//    Console.WriteLine(node.Value);
//    node= node.Next;   
//}