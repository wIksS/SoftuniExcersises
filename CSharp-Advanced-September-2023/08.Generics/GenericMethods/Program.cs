
SoftuniList<int> list = new SoftuniList<int>();

string result = list.GenericMethod("5");

class SoftuniList<TClass>
{
    public T GenericMethod<T>(T input)
    {
        Console.WriteLine(typeof(T).Name);
        Console.WriteLine(typeof(TClass).Name);
        Console.WriteLine(input);

        return default(T);
    }
}