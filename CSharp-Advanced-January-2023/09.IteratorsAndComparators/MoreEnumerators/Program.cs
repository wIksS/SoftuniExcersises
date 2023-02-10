

using System.Collections;

EndlessCollection endless = new EndlessCollection();
foreach (var item in endless)
{
    Console.WriteLine(item);
}


class EndlessCollection : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        return new NumbersEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class NumbersEnumerator : IEnumerator<int>
{
    private int current = 0;
    private Random random = new Random();
    public int Current{ get { 
            return current; } }

    object IEnumerator.Current => Current;


    public bool MoveNext()
    {
        current++;
        if (random.Next() % 10000 == 0)
        {
            return false;
        }
        return true;
    }

    public void Reset()
    {
        current = 0;
    }


    public void Dispose()
    { }
}