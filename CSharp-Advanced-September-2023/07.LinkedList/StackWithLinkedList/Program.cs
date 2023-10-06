// FIFO - last in, first out

LinkedList<int> stack = new LinkedList<int>();

stack.AddLast(1);
stack.AddLast(2);
stack.AddLast(3);    
stack.AddLast(4);

//pop

//Console.WriteLine(stack.Last.Value);
//stack.RemoveLast();


//Console.WriteLine(stack.Last.Value);
//stack.RemoveLast();


//Console.WriteLine(stack.Last.Value);
//stack.RemoveLast();

//Dequeue

Console.WriteLine(stack.First.Value);
stack.RemoveFirst();


Console.WriteLine(stack.First.Value);
stack.RemoveFirst();