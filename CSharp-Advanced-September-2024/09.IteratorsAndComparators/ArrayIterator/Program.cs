
using System.Collections;

int[] array = new int[5] { 1, 2, 3, 4, 5 };
CustomArrayEnumerable<int> enumerableArray=  new CustomArrayEnumerable<int>(array);

foreach (var item in enumerableArray)
{

}

ArrayEnumerator<int> enumerator = new ArrayEnumerator<int>(array);

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

enumerator.Reset();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}


class CustomArrayEnumerable<T> : IEnumerable<T>
{
    private T[] array;

    public CustomArrayEnumerable(T[] array)
    {
        this.array = array;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new ArrayEnumerator<T>(array);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class ArrayEnumerator<T> : IEnumerator<T>
{
    private T[] array;
    private int index = -1;

    public ArrayEnumerator(T[] array)
    {
        this.array = array;
    }

    public object Current
    {
        get
        {
            return this.Current;
        }
    }

    T IEnumerator<T>.Current
    {
        get
        {
            return array[index];
        }
    }

    public bool MoveNext()
    {
        index++;

        return array.Length > index;
    }

    public void Reset()
    {
        index = -1;
    }

    public void Dispose()
    {

    }
}