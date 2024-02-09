

// n -> generate given element n times

GenerateElements(DateTime.Now, 5);

Console.WriteLine(String.Join(",", GenerateElements<string>("Dimitrichko", 10)));
Console.WriteLine(String.Join(",", GenerateElements(100, 10)));
Console.WriteLine(String.Join(",", GenerateElements<DateTime>(DateTime.Now, 10)));

List<T> GenerateElements<T>(T element, int n)
{
    List<T> list = new List<T>();
    for (int i = 0; i < n; i++)
    {
        list.Add(element);
    }

    return list;
}