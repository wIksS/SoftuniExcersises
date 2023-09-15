

using System.Diagnostics;

int n = 500000000;
Stopwatch watch = Stopwatch.StartNew();

Stack<int> stack = new Stack<int>();
for (int i = 0; i < n; i++)
{
    stack.Push(i);
}

watch.Stop();

Console.WriteLine(watch.ElapsedMilliseconds);

 watch = Stopwatch.StartNew(); 

List<int> numbers = new List<int>();
for (int i = 0; i < n; i++)
{
    numbers.Insert(0,i);
}

watch.Stop();

Console.WriteLine(watch.ElapsedMilliseconds);

