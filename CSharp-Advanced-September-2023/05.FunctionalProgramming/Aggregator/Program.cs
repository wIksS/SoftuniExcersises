
Console.WriteLine(Aggregate(1, 10, (x, y) => x + y));
Console.WriteLine(Aggregate(1, 10, (x, y) => x * y));
Console.WriteLine(Aggregate(1, 10, (x, y) => x / y));

long Aggregate(int start, int end, Func<long, long, long> op)
{
    long result = start;
    for (int i = start + 1; i <= end; i++)
        result = op(result, i);
    return result;
}
