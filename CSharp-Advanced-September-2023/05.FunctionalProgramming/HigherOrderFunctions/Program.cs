

//Enumerable.Range(1, 1000)
//    .ToList()
//    .ForEach(x => Console.WriteLine(x));

ForEach(new List<int> { 1,2,3,4,5}, x=> Console.WriteLine(x));

void ForEach(List<int> list, Action<int> action)
{
    foreach (var item in list)
    {
        action(item);
    }
}