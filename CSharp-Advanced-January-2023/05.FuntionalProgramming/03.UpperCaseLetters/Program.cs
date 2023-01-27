Predicate<string> filterByUpperCase = 
    s => s[0] == char.ToUpper(s[0])&& char.IsLetter(s[0]);

string[] input =
    Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(s => filterByUpperCase(s))
    .ToArray();

foreach (var item in input)
{
    Console.WriteLine(item);
}
