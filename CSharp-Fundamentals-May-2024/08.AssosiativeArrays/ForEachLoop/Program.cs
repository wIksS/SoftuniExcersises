
KeyValuePair<string, int> pair = new KeyValuePair<string, int>("C#", 40);

Console.WriteLine(pair.Key);
Console.WriteLine(pair.Value);


Dictionary<string, int> wordCounts = new Dictionary<string, int>()
{
    { "duma", 3},
    { "druga", 5 },
    { "C#", 40},
    { "Java", 2}
};

foreach (KeyValuePair<string, int> item in wordCounts)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}

foreach ((string word, int count) in wordCounts)
{

    Console.WriteLine(word);
    Console.WriteLine(count);
}
