

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

numbers = numbers.OrderByDescending(number => number)
    .Take(3)
    .ToList();

Console.WriteLine($"{string.Join(" ", numbers)}");