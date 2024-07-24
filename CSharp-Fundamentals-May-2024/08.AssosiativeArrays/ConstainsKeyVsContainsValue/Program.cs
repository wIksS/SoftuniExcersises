

using System.Diagnostics;

Dictionary<string, string> dictionary = new Dictionary<string, string>();

for (int i = 0; i < 500000; i++)
{
    dictionary.Add($"key{i}", $"key{i}");
}

Stopwatch watch = Stopwatch.StartNew();

for (int i = 0; i < 20_000; i++)
{
    dictionary.ContainsValue($"key{i}");
}

Console.WriteLine(watch.ElapsedMilliseconds);

 watch = Stopwatch.StartNew();
short val = 0;
for (int i = 0; i < 10_500_000; i++)
{
    dictionary.ContainsKey($"key{val++}");
}

Console.WriteLine(watch.ElapsedMilliseconds);