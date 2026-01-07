

using System.Diagnostics;
int n = 100000;
Stopwatch watch  = Stopwatch.StartNew();

List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    list.Add(i);
}

for (int i = 0; i < n; i++)
{
    int current = list[0];
    list.RemoveAt(0);
}

watch.Stop();
Console.WriteLine(watch.Elapsed);

watch = Stopwatch.StartNew();

Queue<int> queue = new Queue<int>();
for (int i = 0; i < n; i++)
{
    queue.Enqueue(i);
}

for (int i = 0; i < n; i++)
{
    int current = queue.Dequeue();
}

watch.Stop();
Console.WriteLine(watch.Elapsed);