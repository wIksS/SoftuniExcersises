

LinkedList<string> linkedList = new LinkedList<string>();

Queue<string> queue = new Queue<string>();

queue.Enqueue("Dimitrichko");
linkedList.AddLast("Dimitrichko");

queue.Enqueue("Niki");
linkedList.AddLast("Niki");

queue.Enqueue("Goshko");
linkedList.AddLast("Goshko");

queue.Enqueue("Toshko");
linkedList.AddLast("Toshko");

while (queue.Count != 0)
{
    string element = queue.Dequeue();
    Console.WriteLine($"Queue: {element}");
}

LinkedListNode<string> node = linkedList.First;

while (node != null)
{
    Console.WriteLine($"Linked List: {node.Value}");
    linkedList.RemoveFirst();
    node = linkedList.First;
}

 linkedList = new LinkedList<string>();
Console.WriteLine("\n\n");
Stack<string> stack = new Stack<string>();

stack.Push("Dimitrichko");
linkedList.AddFirst("Dimitrichko");

stack.Push("Niki");
linkedList.AddFirst("Niki");

stack.Push("Goshko");
linkedList.AddFirst("Goshko");

stack.Push("Toshko");
linkedList.AddFirst("Toshko");

while (stack.Count != 0)
{
    string element = stack.Pop();
    Console.WriteLine($"Stack: {element}");
}

node = linkedList.First;

while (node != null)
{
    Console.WriteLine($"Linked List: {node.Value}");
    linkedList.RemoveFirst();
    node = linkedList.First;
}