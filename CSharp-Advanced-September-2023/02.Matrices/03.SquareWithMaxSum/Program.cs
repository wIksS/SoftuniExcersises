
int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    //7, 1, 3, 3, 2, 1
    int[] rowValues = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowValues[col];
    }
}

int maxSquareRow = 0;
int maxSquareCol = 0;
int maxSquareSum = int.MinValue;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int currentSquareSum =
            matrix[row, col] +
            matrix[row, col + 1] +
            matrix[row + 1, col] +
            matrix[row + 1, col + 1];

        if (currentSquareSum > maxSquareSum)
        {
            maxSquareSum = currentSquareSum;
            maxSquareRow = row;
            maxSquareCol = col;
        }
    }
}

Console.WriteLine($"{matrix[maxSquareRow, maxSquareCol]} {matrix[maxSquareRow, maxSquareCol + 1]}");

Console.WriteLine($"{matrix[maxSquareRow+1, maxSquareCol]} {matrix[maxSquareRow+1, maxSquareCol + 1]}");

Console.WriteLine(maxSquareSum);