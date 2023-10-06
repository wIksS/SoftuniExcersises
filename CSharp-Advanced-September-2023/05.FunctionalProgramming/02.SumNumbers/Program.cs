string input = Console.ReadLine();
Func<string, int> parser = n => int.Parse(n);
int[] numbers = input.Split(new string[] { ", " },
    StringSplitOptions.RemoveEmptyEntries)
    .Select(parser).ToArray();
Console.WriteLine(numbers.Length);
Console.WriteLine(numbers.Sum());

