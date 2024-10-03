
long multiply = Aggregate(1, 10, Multiply);
Console.WriteLine(multiply);
Console.WriteLine(Aggregate(0,100, (a,b)=>a+b));

long Aggregate(int start, int end, Func<long, long, long> op)
{
    long result = start;
    for (int i = start + 1; i <= end; i++)
        result = op(result, i);
    return result;
}


long Multiply(long a, long b)
{
    return a * b;
}
//0..100