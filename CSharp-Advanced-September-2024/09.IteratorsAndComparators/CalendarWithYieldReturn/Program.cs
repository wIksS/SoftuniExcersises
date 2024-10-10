

using System.Collections;

Calendar calendar = new Calendar();

foreach (var day in calendar)
{
    Console.WriteLine(day);
}

class Calendar : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 366; i++)
        {
            yield return i;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}