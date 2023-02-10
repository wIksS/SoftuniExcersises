

using System.Collections;

foreach (var number in new SoftuniList())
{
    Console.WriteLine(number);
}

class SoftuniList : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 100; i++)
        {
            yield return i;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}