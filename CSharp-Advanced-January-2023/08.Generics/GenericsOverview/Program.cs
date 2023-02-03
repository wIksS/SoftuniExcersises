
List<int> list = new List<int>()
{
    1,2,3,4,5
};

List<long> longList = new List<long>()
{
    1,2,3,4,5,6
};

List<string> stringList = new List<string>()
{
    "edno","dve","chetiri"
};

int[] intArray = PrintList<int>(list);
long[] longArray = PrintList<long>(longList);
string[] stringArray = PrintList<string>(stringList);

T[] PrintList<T>(List<T> list)
{
    T defaultT = default(T);
    T[] array = new T[list.Count];
    int index = 0;
    Type type = typeof(T);
    Console.WriteLine($"Printing List<{type.Name}>");
    foreach (var item in list)
    {
        Console.WriteLine($"Generic Printing: {item}");
        array[index++] = item;
    }

    return array;
}
