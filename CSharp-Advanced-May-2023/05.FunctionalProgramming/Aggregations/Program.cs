
Console.WriteLine(Aggregate(1, 100, (x, y) => x + y));
Console.WriteLine(Aggregate(1, 50, (x, y) => x *y));


long Aggregate(int start, int end, Func<long,long,long> aggregator)
{
    long result = 1;
    for (long i = start; i < end; i++)
    {
        result = aggregator(result,i);
    }

    return result;
}