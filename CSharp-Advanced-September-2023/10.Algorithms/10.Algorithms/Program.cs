

using System.Diagnostics;

List<int> list = Enumerable.Range(0, 25).ToList();
Console.WriteLine(list.Count);
ConstantAlgorithm(list.ToHashSet());
LogNAlgorihm(list);
LinearTime(list);
NLogNAlgorithm(list);
QuadraticAlgorithm(list);
Stopwatch watch = Stopwatch.StartNew();
ExponentialAlgorithm(list,0);

watch.Stop();
Console.WriteLine($"Exponential sort time O(n!): {watch.ElapsedMilliseconds}");

void ConstantAlgorithm(HashSet<int> list)
{
    Stopwatch watch = Stopwatch.StartNew();

    bool exists = list.Contains(5000);

    watch.Stop();
    Console.WriteLine($"Constant time O(1): {watch.ElapsedMilliseconds} {exists}");
}

void LogNAlgorihm(List<int> list)
{
    Stopwatch watch = Stopwatch.StartNew();

    int index = list.BinarySearch(5000);

    watch.Stop();
    Console.WriteLine($"Logn time O(logn): {watch.ElapsedMilliseconds} {index}");
}

void LinearTime(List<int> list)
{
    Stopwatch watch = Stopwatch.StartNew();

    bool exists = false;
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] == 5000)
        {
            exists = true;
        }
    }

    watch.Stop();
    Console.WriteLine($"Linear time O(n): {watch.ElapsedMilliseconds} {exists}");
}

void NLogNAlgorithm(List<int> list)
{
    Stopwatch watch = Stopwatch.StartNew();

    list.Sort();

    watch.Stop();
    Console.WriteLine($"Quicksort time O(nlogn): {watch.ElapsedMilliseconds}");
}

void QuadraticAlgorithm(List<int> NumArray)
{
    Stopwatch watch = Stopwatch.StartNew();

    var arrayLength = NumArray.Count;
    for (int i = 0; i < arrayLength - 1; i++)
    {
        var smallestVal = i;
        for (int j = i + 1; j < arrayLength; j++)
        {
            if (NumArray[j] < NumArray[smallestVal])
            {
                smallestVal = j;
            }
        }
        var tempVar = NumArray[smallestVal];
        NumArray[smallestVal] = NumArray[i];
        NumArray[i] = tempVar;
    }
    watch.Stop();
    Console.WriteLine($"Selection sort time O(n^2): {watch.ElapsedMilliseconds}");
}

void ExponentialAlgorithm(List<int> list, int startIndex)
{

    for (int i = startIndex; i < list.Count; i++)
    {
        ExponentialAlgorithm(list, i + 1);
    }

}