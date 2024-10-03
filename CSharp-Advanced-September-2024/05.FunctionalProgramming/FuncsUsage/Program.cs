

int[] array = new int[] { 4, 32, 52, 6, 2, 17, 132, 18 };
Filter isEvenFunc = IsEven;

array = Where(array, isEvenFunc);
array = Where(array, n => n > 5);

Console.WriteLine(String.Join(" ", array));

int[] Where(int[] array, Filter checker)
{
    List<int> list = new List<int>();

    foreach (var item in array)
    {
        if (checker(item))
        {
            list.Add(item);
        }
    }

    return list.ToArray();
}

bool IsEven(int n)
{
    return n % 2 == 0;
}

delegate bool Filter(int n);