

// words count

Dictionary<string, int> wordsCount = new()
{
    { "duma", 3},
    {"druga", 5 },
    { "C#", 40}
};

Console.WriteLine(wordsCount.ContainsKey("Duma"));
Console.WriteLine(wordsCount.ContainsKey("duma"));

Console.WriteLine(wordsCount.ContainsValue(40));
Console.WriteLine(wordsCount.ContainsValue(5));
Console.WriteLine(wordsCount.ContainsValue(41));


wordsCount["hello"] = 55;
wordsCount["hello"] = 45;
wordsCount["hello"]++;

wordsCount.Remove("duma2");

//wordsCount.Add("hello", 5);

Console.WriteLine(wordsCount["hello"]);

foreach (var wordCount in wordsCount)
{
    Console.WriteLine($"{wordCount.Key} -> {wordCount.Value}");
}