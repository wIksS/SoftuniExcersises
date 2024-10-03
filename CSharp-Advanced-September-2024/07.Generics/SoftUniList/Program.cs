
SoftUniList<int> list = new SoftUniList<int>();

list.Add(5);

SoftUniList<string> stringList = new SoftUniList<string>();

stringList.Add("Hello");
//stringList.Add(5);

class SoftUniList<T>
{
    private T[] array;
    private int index = 0;

    public SoftUniList()
    {
        array = new T[100];
    }

    public void Add<Y>(T element) where Y:class
    {
        array[index++] = element;
    }

    public T Get(int index)
    {
        return this.array[index];
    }
}

class ThreeDOperations<T>
{
    public T AreaRectangle(T a, T b)
    {
        return a * b;
    }
}