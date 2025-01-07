

Stack<int> stack = new Stack<int>();

stack.Push(0);
stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine(stack.Contains(2));

int[] array = stack.ToArray();

Console.WriteLine(String.Join(",", array));

stack.Clear();

Console.WriteLine(stack.Count);

stack.TrimExcess();