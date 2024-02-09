

List<int> largestThreeNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .OrderByDescending(x => x)
    .Take(3)
    .ToList();

Console.WriteLine(String.Join(" ", largestThreeNumbers));