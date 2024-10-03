Predicate<string> checker = n => n[0] == n.ToUpper()[0];

string[] words = Console.ReadLine()
 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
 .Where(word => checker(word))
 .ToArray();

foreach (string word in words)
{
    Console.WriteLine(word);
}
