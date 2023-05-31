

decimal[] numbers = Console.ReadLine()
    .Split(", ")
    .Select(n => decimal.Parse(n))
    .Select(n => n * 1.2m)
    .ToArray();

foreach (var number in numbers)
{
    Console.WriteLine($"{number:f2}");
}