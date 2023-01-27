
int[] arr = new int[] { 1, 2, 3,4,5,6,7 };

int[] evenNumbers = Where(arr, IsEven);

Console.WriteLine(String.Join(" ", evenNumbers));

int[] Where(int[] array, Func<int,bool> filter)
{
    List<int> newList = new List<int>();
    foreach (var number in array)
    {
        if (filter(number))
        {
            newList.Add(number);
        }
    }

    return newList.ToArray();
}

bool IsEven(int x)
{
    return x % 2 == 0;
}