
Func<int, bool> filter = IsOdd;

Predicate<int> predicate = IsOdd;

//new List<int>().Where()


bool IsOdd(int x)
{
    return x % 2 == 0;
}