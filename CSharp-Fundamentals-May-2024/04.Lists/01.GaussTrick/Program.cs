

List<int> list = Console.ReadLine().Split()
    .Select(int.Parse)
    .ToList();


List<int> results = new List<int>();

for (int i = 0; i < list.Count/2; i++)
{
    results.Add(list[i] + list[list.Count - 1 - i]);
}

if (list.Count % 2 == 1)
{
    results.Add(list[list.Count / 2]);
}

Console.WriteLine(String.Join(" ", results));