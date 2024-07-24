

Dictionary<string, int> wordCounts = new Dictionary<string, int>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    int count = int.Parse(Console.ReadLine());

    if (!wordCounts.ContainsKey(word))
    {
        wordCounts.Add(word, count);
    }
    else
    {
        wordCounts[word] += count;
    }
}

foreach (var word in wordCounts)
{
    Console.WriteLine($"{word.Key} -> {word.Value}");
}