
Func<int, bool> funcFilter = IsEvenFilter;
Predicate<int> predicateFilter = IsEvenFilter;


List<int> list = new List<int>();

list.Where()

bool IsEvenFilter(int n)
{
    return n % 2 == 0;
}