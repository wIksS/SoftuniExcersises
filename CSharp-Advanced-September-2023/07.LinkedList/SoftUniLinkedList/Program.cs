

using SoftUniLinkedListCollection;

//list.RemoveLast();

SoftUniLinkedList linkedList = new SoftUniLinkedList();

linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);

linkedList.AddFirst(0);
linkedList.AddFirst(-1);

Console.WriteLine($"Head {linkedList.Head}");
Console.WriteLine($"Tail {linkedList.Tail}");

int listSum = 0;

linkedList.Reverse();
linkedList.Reverse();

linkedList.ForEach(x =>
{
    listSum += x;
    Console.WriteLine($"From Foreach: {x}");
});

Console.WriteLine("Sum: " +listSum);


int[] array = linkedList.ToArray();

Console.WriteLine();
//Node currentNode = linkedList.Head;

//while (currentNode != null)
//{
//    Console.WriteLine(currentNode.Value);
//    currentNode = currentNode.Next;
//}







//Node head = new Node(0);

//head.Next = new Node(1);

//head.Next.Next = new Node(2);

//head.Next.Next.Next = new Node(3);