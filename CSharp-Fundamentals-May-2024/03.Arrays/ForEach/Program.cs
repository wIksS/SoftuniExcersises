
int[] array = { 1, 2, 3, 4, 5 };

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}

Console.WriteLine();

foreach (int currentNumber in array)
{
    array[2] = 10;
    Console.Write(currentNumber + " ");
}