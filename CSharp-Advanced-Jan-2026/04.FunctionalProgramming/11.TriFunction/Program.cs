

int n = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split().ToArray();


string result = FindFirstMatching(names, n, AreCharactersBigger);

Console.WriteLine(result);

string FindFirstMatching(string[] names, int n, Func<string, int, bool> filter)
{
    foreach (string name in names)
    {
        if (filter(name, n))
        {
            return name;
        }
    }

    return "";
}

bool AreCharactersBigger(string input, int n)
{
    int charatacters = 0;

    for (int i = 0; i < input.Length; i++)
    {
        charatacters += input[i];
    }

    return charatacters >= n;
}