
Func<string, int> parse = int.Parse;

int[] numbers = Console.ReadLine()
    .Split(", ")
    .Select(parse)
   .ToArray();

Console.WriteLine(numbers.Length);

Console.WriteLine(numbers.Sum());

