



int[] arr = new int[] { 1, 2, 3, 4 };

int isFound = FindElement(arr, 3);

string isStringFound = FindElement<string>(new string[] { "1", "2" }, "1");

Console.WriteLine(isFound);
Console.WriteLine(isStringFound);

T FindElement<T>(T[] array, T element)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Equals(element))
        {
            return array[i];
        }
    }

    return default(T);
}
