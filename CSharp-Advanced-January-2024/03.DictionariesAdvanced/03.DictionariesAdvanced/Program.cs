

var fruits = new SortedDictionary<string, double>();

fruits["banana"] = 2.20;
fruits["apple"] = 1.40;
fruits["kiwi"] = 3.20;

Console.WriteLine(string.Join(", ", fruits.Keys.ToList()));