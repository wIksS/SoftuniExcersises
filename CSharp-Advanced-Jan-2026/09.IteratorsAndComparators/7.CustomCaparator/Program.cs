

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

//Array.Sort(array, new NumbersComparer());
Comparison<int> comparison = (x, y) =>
{
    if (x % 2 == 0)
    {
        if (y % 2 == 0)
        {
            return x.CompareTo(y);
        }

        return -1;
    }
    else
    {
        if (y % 2 == 0)
        {
            return 1;
        }

        return x.CompareTo(y);
    }
};

Array.Sort(array, comparison);

Console.WriteLine(String.Join(" ", array));


class NumbersComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x % 2 == 0)
        {
            if (y % 2 == 0)
            {
                return x.CompareTo(y);
            }

            return -1;
        }
        else
        {
            if (y % 2 == 0)
            {
                return 1;
            }

            return x.CompareTo(y);
        }
    }
}