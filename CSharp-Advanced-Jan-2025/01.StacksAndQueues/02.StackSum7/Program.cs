
Stack<int> stack = new Stack<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] spllited = command.Split();
    if (spllited[0] == "add")
    {
        int first = int.Parse(spllited[1]);
        int second = int.Parse(spllited[2]);

        stack.Push(first);
        stack.Push(second);
    }
    if (spllited[0] == "remove")
    {
        int n = int.Parse(spllited[1]);

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


