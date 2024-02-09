NonGenericClass nonGeneric = new NonGenericClass();

nonGeneric.Add(5);
nonGeneric.Add("string");
nonGeneric.Add(new NonGenericClass());

class GenericClass<T>
{
    public T x;

    public List<T> list = new List<T>();

    public T Name { get; set; }

    public void Add(T element)
    {
        list.Add(element);
        Console.WriteLine(element);
    }
}

class NonGenericClass
{
    public List<object> list = new List<object>();

    public void Add(object element)
    {
        list.Add(element);
        Console.WriteLine(element);
    }
}