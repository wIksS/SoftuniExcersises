using System;

public class Stack<T> : IEnumerable<T>
{
    private List<T> list;

    public Stack()
    {
        list = new List<T>();
    }

    public void Push(T item)
    {
        list.Add(item);
    }

    public T Pop()
    {
        T last = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return last;
    }
}
