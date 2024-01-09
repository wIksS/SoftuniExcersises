

using System.Diagnostics;

Stopwatch watch = Stopwatch.StartNew(); 

int n = 600_000_000;


Queue<int> queue = new Queue<int>();

for (int i = 0; i < n; i++)
{
    queue.Enqueue(i);
}

for (int i = 0; i < n; i++)
{
    queue.Dequeue();
}

watch.Stop();

Console.WriteLine(watch.ElapsedMilliseconds);

watch = Stopwatch.StartNew();

List<int> list = new List<int>();

for (int i = 0; i < n; i++)
{
    list.Add(i);
}

for (int i = 0; i < n; i++)
{
    list.RemoveAt(0);
}

watch.Stop();

Console.WriteLine(watch.ElapsedMilliseconds);

