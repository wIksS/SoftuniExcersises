

using SoftuniDataStructures;
using System.Diagnostics;

int n = 50_000_000;
Stopwatch watch = Stopwatch.StartNew();
SoftUniList list = new SoftUniList();

for (int i = 0; i < n; i++)
{
    list.Add(i);
}


watch.Stop();

Console.WriteLine($"Custom list resized: {watch.ElapsedMilliseconds}");

watch = Stopwatch.StartNew();

list = new SoftUniList(n+1);

for (int i = 0; i < n; i++)
{
    list.Add(i);
}

watch.Stop();

Console.WriteLine($"Set Capacity custom list: {watch.ElapsedMilliseconds}");

watch = Stopwatch.StartNew();

List<int> csharpList = new List<int>();

for (int i = 0; i < n; i++)
{
    csharpList.Add(i);
}

watch.Stop();

Console.WriteLine($"CSharp List: {watch.ElapsedMilliseconds}");
watch = Stopwatch.StartNew();
csharpList = new List<int>(n+1);

for (int i = 0; i < n; i++)
{
    csharpList.Add(i);
}

watch.Stop();

Console.WriteLine($"CSharp List with capacity: {watch.ElapsedMilliseconds}");
csharpList.TrimExcess();


//CustomQueue queue = new CustomQueue();

//for (int i = 0; i < n; i++)
//{
//    queue.Enqueue(i);
//}
//for (int i = 0; i < n; i++)
//{
//    queue.Dequeue();
//}

//watch.Stop();
//Console.WriteLine(watch.ElapsedMilliseconds);
