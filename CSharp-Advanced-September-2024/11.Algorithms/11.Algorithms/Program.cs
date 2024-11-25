
using System.Diagnostics;

Stopwatch watch = Stopwatch.StartNew(); 
//Exponential(30);
Quadratic(1_000_000);

Console.WriteLine(watch.ElapsedMilliseconds);

void Quadratic(int n)
{
    int x = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            x++;
        }
    }
}

void Exponential(int n)
{
    for (int i = 0; i < n; i++)
    {
        Exponential(i);
    }
}