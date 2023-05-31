
int[,] matrix = new int[3, 3]
    {
        { 1,2,3 },
        { 4,5,6 },
        { 7,8,9 },
    };

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = matrix[row, col] + 50;
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col] + " ");
    }

    Console.WriteLine();
}

foreach (var item in matrix)
{
    Console.WriteLine(item);
}