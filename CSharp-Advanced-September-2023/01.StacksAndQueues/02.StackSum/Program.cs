

Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));


string command = Console.ReadLine().ToLower();

while (command != "end")
{
    //add 1 2
    //remove 5
    string[] splitted = command.Split(' '); 
    if (command.Contains("add"))
    {
        int first = int.Parse(splitted[1]); 
        int second = int.Parse(splitted[2]);
        stack.Push(first);
        stack.Push(second); 
    }
    else if (command.Contains("remove"))
    {
        int n = int.Parse(splitted[1]);
        if (n <= stack.Count)
        {
            for (int i = 0; i < n; i++)
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