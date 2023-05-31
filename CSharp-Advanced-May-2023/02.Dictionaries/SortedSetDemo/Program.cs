

SortedSet<int> sortedSet = new SortedSet<int>(new IntComparer());

sortedSet.Add (0);
sortedSet.Add (11);
sortedSet.Add (22);
sortedSet.Add (3);
sortedSet.Add (4);
sortedSet.Add (55);
sortedSet.Add (66);

foreach (var item in sortedSet)
{
    Console.WriteLine(item);
}

class IntComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y.CompareTo(x);
    }
}