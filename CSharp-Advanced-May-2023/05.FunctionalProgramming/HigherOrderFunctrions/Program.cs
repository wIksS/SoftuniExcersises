Random random = new Random();
int[] array = Enumerable.Range(0, 1000).ToArray();

Select(array, n => n * 5);
Select(array, n => n + random.Next(0, 10000));
Select(array, n => n / 5);
Select(array, n => n * 5);
Select(array, n => n + random.Next(0, 10000));
Select(array, n => n / 5);

int[] Select(int[] array, Func<int,int> operation)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = operation(array[i]);
    }

    return array;
}