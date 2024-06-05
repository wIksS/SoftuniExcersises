
int[] mainArray = { 1, 2, 3 };

ReferenceTypesMethod(mainArray);

Console.WriteLine(mainArray[0]);


int number = 5;

void ReferenceTypesMethod(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }

    newArray[0] = -55;

    Console.WriteLine(newArray[0]);
}