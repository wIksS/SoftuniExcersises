int n = int.Parse(Console.ReadLine());
int[] array = Enumerable.Range(1, n).ToArray(); //[1, 2, 3, 4, 5, 6];
int[] divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();// [1];

List<Func<int, bool>> filters = new List<Func<int, bool>>();

foreach (int divisor in divisors)
{

    Func<int, bool> filter = n =>
    {
        //Console.WriteLine($"Filtering {n} % {x}");
        return n % divisor == 0;
    };

    filters.Add(filter);
}


foreach (var filter in filters)
{
    List<int> filteredArray = new List<int>();
    foreach (var number in array)
    {
        if (filter(number))
            filteredArray.Add(number);
    }

    array = filteredArray.ToArray();
}

Console.WriteLine(String.Join(" ", array));