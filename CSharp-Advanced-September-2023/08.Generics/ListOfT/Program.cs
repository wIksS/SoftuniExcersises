
List<int> list = GenericMethod<int>(5);
List<string> stringList = GenericMethod<string>("Hello");

List<T> GenericMethod<T>(T value)
{
    //Console.WriteLine(value + value);
    List<T> list = new List<T>();

    list.Add(value);
    list.Add(value);
    list.Add(value);

    Console.WriteLine(value);

    return list;
}