

List<int> list = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

Console.WriteLine(String.Join(", ", list));