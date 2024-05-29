

// average - n
// worst - n
// best - 1

int FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return i;
        }
    }

    return -1;
}