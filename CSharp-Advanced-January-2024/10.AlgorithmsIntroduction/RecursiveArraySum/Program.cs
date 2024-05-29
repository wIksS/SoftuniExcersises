
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Console.WriteLine(ArraySum(array));

int ArraySum(int[] array)
{
    if (array.Length == 1)
    {
        return array[0];
    }

    int[] restArray = array.Skip(1).ToArray();

    int restArraySum = ArraySum(restArray);

    return array[0] + restArraySum;
}