
int[,] matrix = ReadMatrix(3, 3);

PrintMatrix(matrix);


static int[,] ReadMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = int.Parse(Console.ReadLine());
        }
    }

    return matrix;
}

static int[,] ReadMatrixOnOneLine(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] rowValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowValues[col];
        }
    }

    return matrix;
}

static void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}