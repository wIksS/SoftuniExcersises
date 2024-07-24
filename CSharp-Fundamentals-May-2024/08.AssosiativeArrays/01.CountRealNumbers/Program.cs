

List<double> numbers = //new List<double>() { 8, 2, 2, 8, 2,5,5,5 };
Console.ReadLine()
.Split()
.Select(double.Parse)
.ToList();

SortedDictionary<double, int> numberCounts = new SortedDictionary<double, int>();

for (int i = 0; i < numbers.Count; i++)
{
    if (!numberCounts.ContainsKey(numbers[i]))
    {
        numberCounts.Add(numbers[i], 0);
    }

    numberCounts[numbers[i]]++;
}

foreach (var number in numberCounts)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}