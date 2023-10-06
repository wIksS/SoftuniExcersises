
List<int> evenNumbers = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine(String.Join(", ", evenNumbers));