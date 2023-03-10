
using System.Diagnostics;
int n = 300000;
int[] arr = Enumerable.Range(0, n).ToArray();

ConstantComplexity(n,arr);
LogNComplexity(n, arr);
LinearComplexity(n, arr);
QuadraticComplexity(n, arr);    
ExponentialComplexity(n, arr);
NfactorialExponentialComplexity(n, arr);

static void ConstantComplexity(int n, int[] array)
{
    HashSet<int> set = new HashSet<int>(array);  

    Stopwatch watch = Stopwatch.StartNew();

    watch.Start();
    for (int i = 0; i < n; i++)
    {
        set.Contains(i);
    }

    watch.Stop();
    Console.WriteLine($"O(1) {watch.ElapsedMilliseconds}");
}

static void LinearComplexity(int n, int[] array)
{
    Stopwatch watch = Stopwatch.StartNew();

    watch.Start();
    for (int i = 0; i < n; i++)
    {
        array.Contains(i);
    }

    watch.Stop();
    Console.WriteLine($"O(n) {watch.ElapsedMilliseconds}");
}

static void QuadraticComplexity(int n, int[] array)
{
    List<int> set = new List<int>();

    Stopwatch watch = Stopwatch.StartNew();
    int counter = 0;
    watch.Start();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            counter++;
        }
    }

    watch.Stop();
    Console.WriteLine($"O(n^2) {watch.ElapsedMilliseconds}");
}

static void ExponentialComplexity(int n, int[] array)
{
    Stopwatch watch = Stopwatch.StartNew();
    watch.Start();

    ExponentialFunction(n);

    watch.Stop();
    Console.WriteLine($"O(2^n) {watch.ElapsedMilliseconds}");
}

static int ExponentialFunction(int n)
{
    if (n <=0)
    {
        return 1;
    }

    return ExponentialFunction(n - 1) + ExponentialFunction(n - 2);
}

static void NfactorialExponentialComplexity(int n, int[] array)
{
    Stopwatch watch = Stopwatch.StartNew();
    watch.Start();

    ExponentialFactorialFunction(n);

    watch.Stop();
    Console.WriteLine($"O(n!) {watch.ElapsedMilliseconds}");
}

static int ExponentialFactorialFunction(int n)
{
    if (n == 0)
    {
        return 1;
    }

    int result = 0;
    for (int i = 0; i < n; i++)
    {
        result += ExponentialFactorialFunction(n - 1);
    }

    return result;
}


static void LogNComplexity(int n, int[] array)
{
    Stopwatch watch = Stopwatch.StartNew();

    watch.Start();
    for (int i = 0; i < n; i++)
    {
        BinarySearch(array, 0, array.Length - 1, i);
    }

    watch.Stop();
    Console.WriteLine($"O(logn) {watch.ElapsedMilliseconds}");
}

static int BinarySearch(int[] array, int start, int end, int element)
{
    if (start > end)
    {
        return -1;
    }
    int middle = (start + end) / 2;

    if (array[middle] == element)
    {
        return middle;
    }

    if (element < array[middle])
    {
        return BinarySearch(array, start, middle - 1, element);
    }
    else
    {
        return BinarySearch(array, middle + 1, end, element);
    }
}