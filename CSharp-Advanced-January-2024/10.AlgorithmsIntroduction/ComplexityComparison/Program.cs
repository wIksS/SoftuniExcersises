




using System.Diagnostics;

int n = 5_0_000;

ConstantTime(n);
LinearTime(n);
NLongN(n);
NLongNMergeSort(n);

QuadraticTime(n);
Console.Write($"Exponential time O(n^n){n} -> ");
Stopwatch stopwatch = Stopwatch.StartNew();
ExponentialTime(n,0);
stopwatch.Stop();

Console.WriteLine(stopwatch.ElapsedMilliseconds);
void ConstantTime(int n)
{
    Console.Write($"Constant time {n} -> ");

    HashSet<int> set = new HashSet<int>(Enumerable.Range(0,n));
    Stopwatch stopwatch = Stopwatch.StartNew();

    //for (int i = 0; i < n; i++)
    //{
        set.Contains(6);
    //}

    stopwatch.Stop();

    Console.WriteLine(stopwatch.ElapsedMilliseconds);
}

void LinearTime(int n)
{
    Console.Write($"Linear time {n} -> ");
    Random r = new Random();
    List<int> list = new List<int>(Enumerable.Range(0, n));
    Stopwatch stopwatch = Stopwatch.StartNew();

    list.Contains(r.Next(0, n));

    stopwatch.Stop();

    Console.WriteLine(stopwatch.ElapsedMilliseconds);
}

void NLongN(int n)
{
    Console.Write($"N LogN time O(nlog(n)){n} -> ");
    Random r = new Random();
    List<int> list = new List<int>(Enumerable.Range(0, n));
    int[] test2 = new int[5];

    for (int i = 0; i < test2.Length; i++)
    {
        list.Add(r.Next(0, n));
    }
    Stopwatch stopwatch = Stopwatch.StartNew();

    list.Sort();

    stopwatch.Stop();

    Console.WriteLine(stopwatch.ElapsedMilliseconds);
}

void NLongNMergeSort(int n)
{
    Console.Write($"N LogN time Merge Sort SoftUni O(nlog(n)){n} -> ");
    Random r = new Random();
    List<int> list = new List<int>(Enumerable.Range(0, n));

    Stopwatch stopwatch = Stopwatch.StartNew();

    MergeSort(list,0, list.Count);

    stopwatch.Stop();

    Console.WriteLine(stopwatch.ElapsedMilliseconds);
}

void ExponentialTime(int n, int start)
{
    for (int i = start; i < n; i++)
    {
        ExponentialTime(n, start + 1);
    }
}

void QuadraticTime(int n)
{
    Console.Write($"Quadratic time Selection Sort O(n^2){n} -> ");
    Random r = new Random();
    List<int> list = new List<int>(Enumerable.Range(0, n));
    Stopwatch stopwatch = Stopwatch.StartNew();

    var arrayLength = list.Count;
    for (int i = 0; i < arrayLength - 1; i++)
    {
        var smallestVal = i;
        for (int j = i + 1; j < arrayLength; j++)
        {
            if (list[j] < list[smallestVal])
            {
                smallestVal = j;
            }
        }
        var tempVar = list[smallestVal];
        list[smallestVal] = list[i];
        list[i] = tempVar;
    }
    stopwatch.Stop();

    Console.WriteLine(stopwatch.ElapsedMilliseconds);
}

List<int> MergeSort(List<int> list, int start, int end)
{
    if (end - start == 1)
    {
        return new List<int>() { list[start] };
    }
    if (end - start <= 0)
    {
        return new List<int>();
    }

    int middle = (start + end) / 2;

    List<int> sortedLeftPart = MergeSort(list, start, middle);
    List<int> sortedRightPart = MergeSort(list, middle, end);
    //if (sortedLeftPart != null)
       // Console.WriteLine(string.Join(",", sortedLeftPart));
    //if (sortedRightPart != null)
        //Console.WriteLine(string.Join(",", sortedRightPart));

    return MergeTwoSortedLists(sortedLeftPart, sortedRightPart);
}

List<int> MergeTwoSortedLists(List<int> left, List<int> right)
{
    List<int> mergedList = new List<int>();
    int leftIndex = 0;
    int rightIndex = 0;

    for (int i = 0; i < left.Count + right.Count; i++)
    {
        if (leftIndex >= left.Count)
        {
            mergedList.Add(right[rightIndex++]);
            continue;
        }
        else if (rightIndex >= right.Count)
        {
            mergedList.Add(left[leftIndex++]);
            continue;
        }

        if (left[leftIndex] <= right[rightIndex])
        {
            mergedList.Add(left[leftIndex++]);
        }
        else
        {
            mergedList.Add(right[rightIndex++]);
        }
    }

    return mergedList;
}

void MeasureAlgorithm(Action<int> algorithm, int n)
{

}