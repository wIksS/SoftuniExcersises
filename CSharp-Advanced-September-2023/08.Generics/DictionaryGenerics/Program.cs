Dictionary<string, int> dict;

var str = "hello";

PrintKeyValuePair<string, int>("Pesho", 6);
PrintKeyValuePair<int, string>(6, "string");


void PrintKeyValuePair<TKey, TValue>(TKey key, TValue value)
{
    Console.WriteLine(typeof(TKey).Name);
    Console.WriteLine(typeof(TValue).Name);

    Console.WriteLine($"{key} : {value}");
}