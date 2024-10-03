int[] array = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

//int[] arrayAsInt = SelectFromStringToInt(array, int.Parse);


Console.WriteLine();

int[] SelectFromStringToInt(string[] array, Func<string, int> map)
{
    int[] arrayAsInt = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arrayAsInt[i] = map(array[i]);
    }

    return arrayAsInt;
}