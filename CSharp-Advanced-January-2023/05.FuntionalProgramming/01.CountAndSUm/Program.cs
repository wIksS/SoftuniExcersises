int[] array = Console.ReadLine().Split(", ").Select(Parse).ToArray();

Console.WriteLine(array.Length);
Console.WriteLine(array.Sum());

int Parse(string input)
{
    return int.Parse(input);
}