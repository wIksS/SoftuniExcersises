

Func<int, bool> func = FilterEven;

Predicate<int> predicate = FilterEven;

int[] arr;

//arr.Where()

bool FilterEven(int n)
{
    return n % 2 == 0;
}