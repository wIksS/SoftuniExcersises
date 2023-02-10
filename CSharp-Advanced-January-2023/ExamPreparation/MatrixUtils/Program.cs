
// 3
// 2
// 1,       2 3 4
// 5 6 7 8
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

int[,] matrix = ReadMatrix<int>(
    () => Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(), rows, cols);


PrintMatrix(matrix, e => Console.Write(e + " "));

static T[,] ReadMatrix<T>(Func<T[]> rowDataGetter, int rows, int cols)
{
    T[,] matrix = new T[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        T[] rowData = rowDataGetter();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowData[col];
        }
    }

    return matrix;
}

static void PrintMatrix<T>(T[,] matrix, Action<T> printer)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            printer(matrix[row, col]);
        }

        Console.WriteLine();
    }
}