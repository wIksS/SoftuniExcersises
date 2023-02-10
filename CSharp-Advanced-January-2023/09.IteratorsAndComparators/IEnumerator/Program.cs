using System.Collections;

List<int> numbers = new List<int>() { 5, 1, 6, 13, 7, 2 };

ListEnumerator enumerator = new ListEnumerator();

while (enumerator.Current < numbers.Count)
{
    Console.WriteLine(numbers[enumerator.Current]);
    enumerator.MoveNext();
}



class ListEnumerator : IEnumerator<int>
{
    public int Current { get; set; }

    object IEnumerator.Current
    {
        get { return Current; }
    }

    public void Dispose(){ }

    public bool MoveNext()
    {
        Current++;

        return true;
    }

    public void Reset()
    {
        Current = 0;
    }
}