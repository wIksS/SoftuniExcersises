using System.Collections;

List<int> numbers = new List<int>() { 5, 1, 6, 13, 7, 2 };

//ListEnumerator enumerator = new ListEnumerator(numbers);

//do
//{
//    Console.WriteLine(enumerator.Current);
//} while (enumerator.MoveNext());

//enumerator.Reset();

SoftUniList softuniList = new SoftUniList(numbers);

foreach (var num in softuniList)
{
    Console.WriteLine(num);
}

IEnumerator<int> enumerator = softuniList.GetEnumerator();

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}
enumerator.Reset();

class SoftUniList : IEnumerable<int>
{
    private List<int> list;
    public SoftUniList(List<int> list)
    {
        this.list = list;
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var item in list)
        {
            yield return item;
        }

        //return new ListEnumerator(list);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class ListEnumerator : IEnumerator<int>
{
    private List<int> list;
    private int index =-1;
    public ListEnumerator(List<int> list)
    {
        this.list = list;
    }

    public int Current { get {
            return list[index]; } }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        index++;

        if (index == list.Count)
        {
            return false;
        }

        return true;
    }

    public void Reset()
    {
        index = 0;
    }
}

