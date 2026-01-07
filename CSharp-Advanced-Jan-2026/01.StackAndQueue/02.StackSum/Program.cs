int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
Stack<int> stack = new Stack<int>(numbers);

string command = Console.ReadLine().ToLower();

while (command != "end")
{
	string[] splitted = command.Split(" ");
	// Add 1 2
	if (command.Contains("add"))
	{
		int first = int.Parse(splitted[1]);
		int second = int.Parse(splitted[2]);
		stack.Push(first);
		stack.Push(second);
	}
	if (command.Contains("remove"))
	{
		//Remove 4
		int count = int.Parse(splitted[1]);

		if (stack.Count >= count)
		{
			for (int i = 0; i < count; i++)
			{
				stack.Pop();
			}
		}
	}

	command = Console.ReadLine().ToLower();
}

int sum = 0;

while (stack.Count > 0)
{
	sum += stack.Pop();
}

Console.WriteLine($"Sum: {sum}");