

using System.Diagnostics;
using SoftUniLinkedListCollection;

int n = 5000000;
int x = 500;

List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    list.Add(i);
}

SoftUniLinkedList softUniList = new SoftUniLinkedList();
for (int i = 0; i < n; i++)
{
    softUniList.AddFirst(i);
}

Stopwatch watch = Stopwatch.StartNew();
for (int i = 0; i < x; i++)
{
    //list.Insert(0, i);
    list.Reverse();
}

watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);

//watch = Stopwatch.StartNew();
//LinkedList<int> linkedList = new LinkedList<int>();
//for (int i = 0; i < n; i++)
//{
//    linkedList.AddFirst(i);
//}

//watch.Stop();
//Console.WriteLine(watch.ElapsedMilliseconds);

watch = Stopwatch.StartNew();
for (int i = 0; i < x; i++)
{
    //softUniList.AddFirst(i);
    softUniList.Reverse();
}

watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);