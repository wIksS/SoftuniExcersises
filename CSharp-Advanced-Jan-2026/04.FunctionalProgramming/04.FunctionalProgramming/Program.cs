Action<string[]> printer;

printer = PrintNamesNewLine;

string[] input = Console.ReadLine().Split();

printer(input);
//printer(["1", "2"]);
//printer(["5", "1"]);
//printer(["1", "2"]);
//printer(["1", "2"]);
//printer(["1", "2"]);
//printer(["1", "2"]);
//printer(["1", "2"]);
//printer(["1", "2"]);
//printer(["1", "2"]);
//printer(["1", "2"]);

void PrintNamesNewLine(string[] names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}

void PrintNamesDashes(string[] names)
{
    foreach (var name in names)
    {
        Console.Write(name + " - ");
    }
}
