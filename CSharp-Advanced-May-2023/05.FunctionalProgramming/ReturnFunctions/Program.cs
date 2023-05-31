Func<string, Func<int, bool>> filterFunc = GetFilter;


Func<int, bool> filter = filterFunc("even");

Console.WriteLine(filter(5));


Func<int, bool> GetFilter(string filterType)
{
    if (filterType == "even")
    {
        return n =>
        {
            Console.WriteLine("Here");
            return n % 2 == 0;
        };
    }

    return n => true;
}

