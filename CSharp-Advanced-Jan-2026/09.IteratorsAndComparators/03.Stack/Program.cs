
string command = Console.ReadLine();
CustomStack.Stack<string> stack = new CustomStack.Stack<string>();
while (command != "END")
{
    string[] input = command.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

    if (input[0] == "Push")
    {
        string[] elements = input[1..];
        foreach (string element in elements)
        {
            stack.Push(element);
        }
    }
    else
    {
        try
        {
            stack.Pop();
        }
        catch(ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("No elements");
        }
    }

    command = Console.ReadLine();
}

foreach (var item in stack)
{
    Console.WriteLine(item);
}
foreach (var item in stack)
{
    Console.WriteLine(item);
}