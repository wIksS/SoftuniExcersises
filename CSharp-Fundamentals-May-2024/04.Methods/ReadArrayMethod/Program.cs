
PrintHello();

int[] array = ReadArray(", ");

Console.WriteLine(String.Join(",", array));

int[] ReadArray(string splitter)
{
    int[] array = Console.ReadLine()
        .Split(splitter)
        .Select(int.Parse)
        .ToArray();

    return array;
}

void PrintHello()
{
    Console.WriteLine("Before return Hello");

    return;

    Console.WriteLine("After return Hello");
}