
using System.Diagnostics;
using System.Text;

string text = "hello";

text += "o";

Stopwatch watch = new Stopwatch();

watch.Start();

for (int i = 0; i < 10000; i++)
{
    text += i.ToString();
}


watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);
Console.WriteLine(text);
watch = new Stopwatch();

watch.Start();
StringBuilder sb = new StringBuilder(); 

for (int i = 0; i < 100000000; i++)
{
    sb.Append(i.ToString());
}


watch.Stop();

Console.WriteLine(watch.ElapsedMilliseconds);
