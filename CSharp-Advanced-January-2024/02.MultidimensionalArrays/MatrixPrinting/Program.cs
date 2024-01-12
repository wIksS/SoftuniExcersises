int[,] matrix = new int[4, 3]
{
    {1, 2, 3 },
    {4, 5, 6 },
    {7, 8, 9 },
    {1, 1, 9 },
};

Console.WriteLine($"Rows: {matrix.GetLength(0)}");
Console.WriteLine($"Cols: {matrix.GetLength(1)}");

Console.Write("[ ");

for (int row = 0; row < matrix.GetLength(0); row++)
{
    Console.Write("[");
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row,col] + " ");
    }

    Console.Write("], ");
}

Console.Write("]");
