using CustomLinkedList;
using System.Diagnostics;

int insertions = 100000000;

Stopwatch watch = Stopwatch.StartNew();

//InsertFirstList(insertions);

watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);

 watch = Stopwatch.StartNew();

InsertFirstSoftuniLinkedList(insertions);

watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);

void InsertFirstList(int insertions)
{
    List<int> list = new List<int>();   

    for (int i = 0; i < insertions; i++)
    {
        list.Insert(0, i);
    }
}

void InsertFirstSoftuniLinkedList(int insertions)
{
    SoftuniLinkedList list = new SoftuniLinkedList();

    for (int i = 0; i < insertions; i++)
    {
        list.AddFirst(i);
    }
}