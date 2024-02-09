
var dict = new Dictionary<string, object>();

var customDict = new CustomDictionary<string, object>();

GenericClass<int> intGeneric = new GenericClass<int>();

intGeneric.Name = 55;

intGeneric.Add(100);

intGeneric.Add(55);

GenericClass<string> stringGeneric = new GenericClass<string>();

stringGeneric.Add("string");

class GenericClass<T>
{
    public T x;

    public  List<T> list = new List<T>();

    public T Name { get; set; }

    public void Add(T element)
    {
        list.Add(element);
        Console.WriteLine(element);
    }
}

class CustomDictionary<TKey, TValue>
{
    TKey[] keys;
    TValue[] values;


}