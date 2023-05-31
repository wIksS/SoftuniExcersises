
using Performance;
using System.Diagnostics;

int n = 5000000;
int operations = 500000;

//ListContainsPerformance(n, operations);
HashSetContainsPerformance(n, operations);
SoftuniSetContainsPerformance(n, operations);
//ListRemovePerformance(n, operations);
//HashSetRemovePerformance(n, operations);

static void ListContainsPerformance(int n, int operations)
{
    //List<int> list = new List<int>(Enumerable.Range(0, n));
    List<string> list = new List<string>(Enumerable.Range(0, n).Select(x=>x.ToString()));

    Stopwatch watch = Stopwatch.StartNew();

    for (int i = 0; i < operations; i++)
    {
        list.Contains(i.ToString());
    }

    Console.WriteLine($"List Contains -> {watch.ElapsedMilliseconds}ms");
}

static void ListRemovePerformance(int n, int operations)
{
    List<int> list = new List<int>(Enumerable.Range(0, n));

    Stopwatch watch = Stopwatch.StartNew();

    for (int i = 0; i < operations; i++)
    {
        list.Remove(i);
    }

    Console.WriteLine($"List Remove -> {watch.ElapsedMilliseconds}ms");
}


static void HashSetRemovePerformance(int n, int operations)
{
    HashSet<int> list = new HashSet<int>(Enumerable.Range(0, n));

    Stopwatch watch = Stopwatch.StartNew();

    for (int i = 0; i < operations; i++)
    {
        list.Remove(i);
    }

    Console.WriteLine($"HashSet Remove -> {watch.ElapsedMilliseconds}ms");
}


static void HashSetContainsPerformance(int n, int operations)
{
    //HashSet<int> list = new HashSet<int>(Enumerable.Range(0, n));
    HashSet<string> list = new HashSet<string>(Enumerable.Range(0, n).Select(x => x.ToString()));

    Stopwatch watch = Stopwatch.StartNew();

    for (int i = 0; i < operations; i++)
    {
        list.Contains(i.ToString());
    }

    Console.WriteLine($"HashSet Contains -> {watch.ElapsedMilliseconds}ms");
}


static void SoftuniSetContainsPerformance(int n, int operations)
{
    //HashSet<int> list = new HashSet<int>(Enumerable.Range(0, n));
    SoftuniHashset list = new SoftuniHashset(Enumerable.Range(0, n).Select(x => x.ToString()));

    Stopwatch watch = Stopwatch.StartNew();

    for (int i = 0; i < operations; i++)
    {
        list.Contains(i.ToString());
    }

    Console.WriteLine($"Softuni HashSet Contains -> {watch.ElapsedMilliseconds}ms");
}