string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

Predicate<string> isUpper = w => Char.IsUpper(w[0]);
string[] upperCaseWords = 
    words.Where(w => isUpper(w))
    .ToArray();

foreach (var word in upperCaseWords)
{
    Console.WriteLine(word);
}