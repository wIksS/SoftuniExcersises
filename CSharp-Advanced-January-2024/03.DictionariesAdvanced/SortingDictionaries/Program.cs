

var fruits = new Dictionary<string, double>();

fruits["banana"] = 2.20;
fruits["melon"] = 1.40;
fruits["dinq"] = 1.40;
fruits["apple"] = 1.40;
fruits["kiwi"] = 3.20;


fruits = fruits
    .OrderBy(f => f.Value)
    .ThenByDescending(f=> f.Key)
    .ToDictionary(f => f.Key, f => f.Value);

Console.WriteLine(string.Join("\n", fruits.ToList()));