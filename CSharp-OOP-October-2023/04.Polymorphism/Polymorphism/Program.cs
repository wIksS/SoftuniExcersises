
List<int> list = Enumerable.Range(0, 1000).ToList();

PrintCollection(list);

void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine($"-----!{item}!----");
    }
}

