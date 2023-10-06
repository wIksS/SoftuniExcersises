

LinkedList<int> linkedList = new LinkedList<int>();

linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddLast(5);

Console.WriteLine(linkedList.First.Value); 
Console.WriteLine(linkedList.Last.Value);

linkedList.AddLast(6);
linkedList.AddFirst(-1);

Console.WriteLine(linkedList.First.Value);
Console.WriteLine(linkedList.Last.Value);


