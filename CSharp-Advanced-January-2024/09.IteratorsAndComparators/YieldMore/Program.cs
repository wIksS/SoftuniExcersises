
using System.Collections;

foreach (var item in new NumbersGenerator())
{
    Console.WriteLine(item);
}


class NumbersGenerator : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        while (true)
        {
            yield return 5;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}