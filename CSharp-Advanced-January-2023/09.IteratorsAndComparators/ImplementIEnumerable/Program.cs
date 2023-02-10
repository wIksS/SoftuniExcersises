
using System.Collections;

SoftuniList list = new SoftuniList();

foreach (var item in list)
{
    Console.WriteLine(item);
}

class SoftuniList : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        return null;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}