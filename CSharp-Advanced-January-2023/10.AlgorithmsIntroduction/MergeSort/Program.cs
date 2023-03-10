
int[] array = new int[] { 5, 4, 7};

int[] sortedArray = MergeSort(array, 0, array.Length-1);

Console.WriteLine(String.Join(",",sortedArray));

int[] MergeSort(int[] array, int start, int end)
{
    if (start > end || start < 0 || end >= array.Length)
    {
        return null;
    }
    if (start == end)
    {
        return new int[] { array[start] };
    }

    int middle = (start + end) / 2;

    int[] leftArray = MergeSort(array, start, middle);
    int[] rightArray = MergeSort(array, middle+1, end);

    int[] sortedArray = new int[leftArray.Length + rightArray.Length];
    int leftIndex = 0;
    int rightIndex = 0;
    for (int i = 0; i < sortedArray.Length; i++)
    {
        if (leftIndex >= leftArray.Length)
        {
            sortedArray[i] = rightArray[rightIndex];
            rightIndex++;
            continue;
        }
        if (rightIndex >= rightArray.Length)
        {
            sortedArray[i] = leftArray[leftIndex];
            leftIndex++;
            continue;
        }
        if ( leftArray[leftIndex] < rightArray[rightIndex])
        {
            sortedArray[i] = leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            sortedArray[i] = rightArray[rightIndex];
            rightIndex++;
        }
    }

    return sortedArray;

}