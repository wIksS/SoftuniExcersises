

using System.Diagnostics;
using System.Text;
StringBuilder sb = new StringBuilder();
StringBuilder sb1 = new StringBuilder();
StringBuilder sb2 = new StringBuilder();

try
{

    int nString = 50_000;
    int n = 100_000_0000;

    string text = "";
    Stopwatch watch = new Stopwatch();
    watch.Start();

    for (int i = 0; i < nString; i++)
    {
        text = String.Concat(text, "hello");
    }

    watch.Stop();
    Console.WriteLine(watch.ElapsedMilliseconds);

    //Console.WriteLine(text);

    watch = new Stopwatch();
    watch.Start();

    for (int i = 0; i < n; i++)
    {
        sb.Append("hello");
        sb1.Append("hello");
        sb2.Append("hello");
    }

    watch.Stop();

    Console.WriteLine(watch.ElapsedMilliseconds);
    Console.WriteLine(sb.ToString());
}
finally
{
    Console.WriteLine("Total memeory:");
    Console.WriteLine(GC.GetTotalMemory(true) / 1024.0 / 1024 / 1024);
    Console.WriteLine($"SB lenght: {sb.Length}");
}