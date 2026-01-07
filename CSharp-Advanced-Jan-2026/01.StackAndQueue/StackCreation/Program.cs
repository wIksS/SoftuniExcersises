
List<string> stack = new();

Console.WriteLine(stack.Count);

List<string> names = new List<string>() { "pesho", "gosho" };
Stack<string> strings = 
    new Stack<string>(names);

Console.WriteLine(strings.Pop());