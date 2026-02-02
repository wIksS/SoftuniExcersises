

List<string> names = Console.ReadLine().Split().ToList();

string command = Console.ReadLine();

while (command != "Party!")
{
    Func<string, bool> filter = null;
    string[] input = command.Split();
    string type = input[0];

    string filterType = input[1];

    switch (filterType)
    {
        case "Length":
            int filteredLength = int.Parse(input[2]);
            filter = s => s.Length == filteredLength;
            break;
        case "StartsWith":
            filter = s => s.StartsWith(input[2]);
            break;
        case "EndsWith":
            filter = s => s.EndsWith(input[2]);
            break;
        default:
            break;
    }

    if (type == "Remove")
    {
        names = names.Where(n => !filter(n)).ToList();
    }
    else if (type == "Double")
    {
        List<string> doubledNames = new List<string>();
        foreach (string name in names)
        {
            doubledNames.Add(name);

            if (filter(name))
            {
                doubledNames.Add(name);
            }
        }

        names = doubledNames;
    }

    command = Console.ReadLine();
}

if(names.Count > 0)
    Console.WriteLine($"{String.Join(", ", names)} are going to the party!");
else
    Console.WriteLine($"Nobody is going to the party!");
