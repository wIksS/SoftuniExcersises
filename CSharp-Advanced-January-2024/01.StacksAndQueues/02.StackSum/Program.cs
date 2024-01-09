
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

Stack<int> stack = new Stack<int>(numbers);

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] splitted = command.Split(' ');
    int first = int.Parse(splitted[1]);

    if (splitted[0] == "add")
    {
        int second = int.Parse(splitted[2]);

        stack.Push(first);
        stack.Push(second);
    }
    else
    {
        if (stack.Count >= first)
        {
            for (int i = 0; i < first; i++)
            {
                stack.Pop();
            }
        }
    }

    command = Console.ReadLine().ToLower();
}


Console.WriteLine($"Sum: {stack.Sum()}");