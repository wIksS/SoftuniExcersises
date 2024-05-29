

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

while (array.Length > 1)
{
    int[] condensed = new int[array.Length - 1];
    for (int i = 0; i < array.Length-1; i++)
    {
        condensed[i] = array[i] + array[i + 1];
    }

    array = condensed;
}

Console.WriteLine(array[0]);