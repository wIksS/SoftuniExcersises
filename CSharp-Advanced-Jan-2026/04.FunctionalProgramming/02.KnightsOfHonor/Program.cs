

string[] input = Console.ReadLine().Split();

Func<string, string> formatter = SirAppender;

Action<string[], Func<string, string>> printer = PrintWithFormat;

printer(input, SirAppender);

void PrintWithFormat(string[] input, Func<string, string> formatter)
{
    foreach (var item in input)
    {
        Console.WriteLine($"{formatter(item)}");
    }
}

string SirAppender(string input)
{
    return "Sir " + input;
}