
List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

Dictionary<double, int> numberOccurrences = new Dictionary<double, int>();

foreach (var number in list)
{
    if (!numberOccurrences.ContainsKey(number))
    {
        numberOccurrences.Add(number, 0);
    }

    numberOccurrences[number]++;
}

foreach (var number in numberOccurrences)
{
    Console.WriteLine($"{number.Key} - {number.Value} times");
}
