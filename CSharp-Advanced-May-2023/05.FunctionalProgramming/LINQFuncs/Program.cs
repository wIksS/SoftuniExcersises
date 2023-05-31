

int[] arr = new int[] { 1, 2, 3, 4, 5 };

arr = Where(arr, n => n % 2 == 0);
arr = Where(arr, n => n > 8);
arr = Where(arr, n => n > 0);
Console.WriteLine(String.Join(" ", arr));

//arr = arr.Where(n => n % 2 == 0).ToArray();

int[] Where(int[] array, Func<int, bool> filter)
{
    List<int> list = new List<int>();

    foreach (int i in array)
    {
        if (filter(i))
        {
            list.Add(i);
        }
    }

    return list.ToArray();
}