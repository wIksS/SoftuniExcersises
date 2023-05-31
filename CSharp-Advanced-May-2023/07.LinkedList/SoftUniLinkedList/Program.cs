

using SoftUniLinkedList;

//CustomLinkedList linkedList = new CustomLinkedList();

//linkedList.AddLast(1);
//linkedList.AddLast(2);
//linkedList.AddLast(3);

//linkedList.AddFirst(1);
//linkedList.AddFirst(2);
//linkedList.AddFirst(3);

//Node node = linkedList.Head;

//while (node != null)
//{
//    Console.WriteLine(node.Value);
//    node = node.Next;
//}




CustomLinkedList list = new CustomLinkedList();

list.AddLast(1);
list.AddLast(2);
list.AddLast(3);
list.AddLast(4);
list.AddLast(5);

list.ForEach(x => global::System.Console.WriteLine(x.Value));

Console.WriteLine("Reverse");
list.Reverse();
list.AddLast(5);
list.ForEach(x => global::System.Console.WriteLine(x.Value));
Console.WriteLine("Reverse");

list.Reverse();

list.ForEach(x => global::System.Console.WriteLine(x.Value));
list.Reverse();

list.ForEach(x => global::System.Console.WriteLine(x.Value));
return;

CustomLinkedList stack = new CustomLinkedList();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

stack.ForEach(x =>
{
    Console.WriteLine($"For each is cool -> {x.Value}");
});

int[] array = stack.ToArray();

Console.WriteLine($"{string.Join(", ", array)}");

while (stack.Count > 0)
{
    int topElement = stack.Pop().Value;

    Console.WriteLine(topElement);
}










//Node ten = new Node(10);
//Node twenty = new Node(20);
//Node thirty = new Node(30);
//Node forty = new Node(40);


//ten.Next = twenty;
//twenty.Previous = ten;

//twenty.Next = thirty;
//thirty.Previous = twenty;

//thirty.Next = forty;
//forty.Previous = thirty;

//Node head = new Node(10,
//                new Node(20,
//                    new Node(30,
//                        new Node(40))));
//head.Next.Next.Next = head;

//Node currentNode = head;

//while (currentNode != null)
//{
//    Console.WriteLine(currentNode.Value);
//    currentNode = currentNode.Next;
//}