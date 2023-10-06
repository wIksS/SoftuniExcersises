

List<int> numbers = Enumerable.Range(1, 10000).ToList();

numbers.FirstOrDefault(x => x==5);
//numbers = numbers
//    .Where(x => x < 1000)
//    .Where(x => x % 7 == 0)
//    .Where(x => x > 100)
//    .ToList();


numbers = Where(numbers, IsSmallerThan1000);
numbers = Where(numbers, x => x % 7 == 0);
numbers = Where(numbers, x => x > 100);

Console.WriteLine(String.Join(",",numbers));

List<int> Where(List<int> list, Func<int, bool> filter)
{
    List<int> filteredList = new List<int>();
    for (int i = 0; i < list.Count; i++)
    {
        if (filter(list[i]) == true)
        {
            filteredList.Add(list[i]);
        }
    }

    return filteredList;
}

bool IsSmallerThan1000(int x)
{
    return x < 1000;
}

Tuple<int,string,string> ReturnList()
{
    return new Tuple<int, string, string>(5,"x","y");
}