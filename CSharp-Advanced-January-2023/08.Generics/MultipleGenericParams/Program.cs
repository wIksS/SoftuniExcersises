

Dictionary<int, string> dictionary = new Dictionary<int, string>();
foreach (KeyValuePair<int,string> item in dictionary)
{

}

KeyValuePair<int,string> result = CreateKeyValuePair<int, string, DateTime>(5, "6");

KeyValuePair<TKey,TValue> CreateKeyValuePair<TKey, TValue, T3>(TKey key, TValue value)
{
    Console.WriteLine(key);
    Console.WriteLine(value);
    return new KeyValuePair<TKey, TValue>(key, value);
}