

List<string> list = new List<string> { "1", "2" };

IReadOnlyCollection<string> readOnlyList = list.AsReadOnly();

foreach (var item in readOnlyList)
{
    Console.WriteLine(item);
}

readOnlyList.ToList();