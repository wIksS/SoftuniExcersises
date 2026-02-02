

string[] names = Console.ReadLine().Split();

string command = Console.ReadLine();

Dictionary<string, Func<string, bool>> filters = new Dictionary<string, Func<string, bool>>();

while (command != "Print")
{
    string[] input = command.Split(';');
    Func<string, bool> filter = null;
    string filterType = input[1];
    string filterValue = input[2];
    if (input[0] == "Remove filter")
    {
        filters.Remove($"{filterType};{filterValue}");

    }
    if (input[0] == "Add filter")
    {
        switch (filterType)
        {
            case "Starts with":
                filter = s => s.StartsWith(filterValue);
                break;

            case "Ends with":
                filter = s => s.StartsWith(filterValue);
                break;

            case "Length":
                filter = s => s.Length == int.Parse(filterValue);
                break;

            case "Contains":
                filter = s => s.Contains(filterValue);
                break;
            default:
                break;
        }

        filters.Add($"{filterType};{filterValue}", filter);
    }
    command = Console.ReadLine();
}

foreach (var (filterName, filter) in filters)
{
    names = names.Where(s => !filter(s)).ToArray();
}

Console.WriteLine($"{string.Join(" ", names)}");