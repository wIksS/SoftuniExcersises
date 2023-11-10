

List<int> list = Enumerable.Range(0,1000000000).ToList();
Console.WriteLine($"List count: {list.Count}");
Console.WriteLine(BinarySearch(list,0,list.Count, -1));

int BinarySearch(List<int> list, int start, int end, int element)
{
    if (end < -1 || start >= list.Count || end < start )
    {
        return -1;
    }
    int middle = (start + end) / 2;

    if (list[middle] == element)
    {
        return middle;
    }
    Console.WriteLine($"Operation {++Counter.Count}");

    if (list[middle] > element)
    {
        return BinarySearch(list, start, middle - 1, element);
    }
    else
    {
        return BinarySearch(list, middle + 1, end, element);
    }
}

class Counter
{
    public static int Count = 0;
}