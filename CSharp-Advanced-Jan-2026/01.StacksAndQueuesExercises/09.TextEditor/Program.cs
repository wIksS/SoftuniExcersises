


using System.Text;

int n = int.Parse(Console.ReadLine());

Stack<string> states = new Stack<string>();

//1 texttoadd
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split();
    StringBuilder current = new StringBuilder();
    if (states.Count > 0)
    {
        current.Append(states.Peek());
    }

    if (command[0] == "1")
    {
        current.Append(command[1]);
        states.Push(current.ToString());
    }
    if (command[0] == "2")
    {
        int count = int.Parse(command[1]);
        current.Remove(current.Length - count, count);

        states.Push(current.ToString());
    }
    if (command[0] == "3")
    {
        int index = int.Parse(command[1]);

        Console.WriteLine(current[index-1]);
    }
    if (command[0] == "4")
    {
        if (states.Count > 0)
        {
            states.Pop();
        }
    }

    //Console.WriteLine($"Current stack: {String.Join(", ", states.ToList())}");
}