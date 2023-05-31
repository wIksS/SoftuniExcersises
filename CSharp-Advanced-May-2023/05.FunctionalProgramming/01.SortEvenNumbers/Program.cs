

string[] strings = new string[] { "1", "2", "3" };

//int[] numbers = strings.Select(ParseString).ToArray();

int[] sortedNumbers = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .Where((int n) =>
    {
        return n % 2 == 0;
    })
    .OrderBy(mojevsichko => mojevsichko)
    .ToArray();

Console.WriteLine(String.Join(", ", sortedNumbers));


int OrderByNumber(int n)
{
    return n;
}

int ParseString(string input)
{
    return int.Parse(input);
}