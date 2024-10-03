

using CustomHashset;
using System.Diagnostics;

List<string> list = new List<string>();
HashSet<string> set = new HashSet<string>();

for (int i = 0; i < 500000; i++)
{
    var x = RandomString(5);
    set.Add(x);
    list.Add(x);
}


Stopwatch watch = new Stopwatch();
watch.Start();
for (int i = 0; i < 30000; i++)
{
    list.Contains(list[i%list.Count]);
}

watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);

watch = new Stopwatch();
watch.Start();
for (int i = 0; i < 3000000; i++)
{
    
    set.Contains(list[i%list.Count]);
}

watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);

string RandomString(int length)
{
    Random random = new Random();

    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
}