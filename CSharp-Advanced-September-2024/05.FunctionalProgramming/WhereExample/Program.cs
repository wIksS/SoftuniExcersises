

int[] array = Enumerable.Range(0, 100000).ToArray();

array = array
    .Where(x => x % 2 == 0)
    .Where(IsPrime)
    .Where(IsFibonacci)
    .Where(x=> x > 1000)
    .ToArray();


bool IsFibonacci(int arg)
{
    throw new NotImplementedException();
}

bool IsPrime(int x)
{
    throw new NotImplementedException();
}

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