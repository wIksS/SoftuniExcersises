var fruits = new SortedDictionary<string, double>();

fruits["kiwi"] = 4.50;
fruits["orange"] = 2.50;
fruits["banana"] = 2.20;


foreach (var fruit in fruits)
{
    Console.WriteLine($"{fruit.Key} : {fruit.Value}");
}