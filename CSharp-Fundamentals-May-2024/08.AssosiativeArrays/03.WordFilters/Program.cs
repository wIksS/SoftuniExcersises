

string[] words = Console.ReadLine()
    .Split(' ')
    .Where(w => w.Length % 2 == 0)
    .ToArray();

Console.Write(string.Join("\n", words));