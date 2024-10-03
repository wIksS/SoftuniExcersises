
using System.Diagnostics;

int n = 15_500_000;

LinkedList<int> linkedList = new LinkedList<int>();
Stopwatch watch = new Stopwatch();
watch.Start();
for (int i = 0; i < n; i++)
{
    linkedList.AddFirst(i);
}

watch.Stop();
Console.WriteLine($"Linked List AddFirst : {watch.ElapsedMilliseconds}");

List<int> list = new List<int>();

 watch = new Stopwatch();
watch.Start();
for (int i = 0; i < n; i++)
{
    list.Insert(0, i);
}

watch.Stop();
Console.WriteLine($"List AddFirst : {watch.ElapsedMilliseconds}");