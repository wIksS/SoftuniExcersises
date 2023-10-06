List<int> list;

GenericList<string> list2;

GenericList<int> genericList = new GenericList<int>();

genericList.AddElement(1);
genericList.AddElement(2);
genericList.AddElement(3);
genericList.AddElement(4);

genericList.PrintAllElements();

class GenericList<T>
{
    private T[] internalArray;
    private int index;

    public GenericList()
    {
        internalArray = new T[10];
    }

    public T[] InternalArray
    {
        get { return internalArray; }
        set { internalArray = value; }
    }

    public T FirstElement { get { return internalArray[0]; } }

    public void AddElement(T element)
    {
        internalArray[index++] = element;
    }

    public void PrintAllElements()
    {
        foreach (var item in internalArray)
        {
            Console.WriteLine(item);
        }
    }
}
