

int n = int.Parse(Console.ReadLine());

HashSet<string> names = new HashSet<string>();

Dictionary<string, List<int>> dict;

names.OrderBy(x => x).ToHashSet();
for(int i = 0; i < n; i++)
{
    names.Add(Console.ReadLine());
}

foreach (var item in names)
{
    Console.WriteLine(item);
}