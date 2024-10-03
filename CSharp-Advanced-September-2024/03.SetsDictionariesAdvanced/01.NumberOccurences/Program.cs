

List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

Dictionary<double, int> numberTimes = new Dictionary<double, int>();

foreach (var number in numbers)
{
    if (!numberTimes.ContainsKey(number))
    {
        numberTimes.Add(number, 1);
    }
    else
    {
        numberTimes[number]++;
    }
}

foreach (var numberTime in numberTimes)
{
    Console.WriteLine($"{numberTime.Key} - {numberTime.Value} times");
}