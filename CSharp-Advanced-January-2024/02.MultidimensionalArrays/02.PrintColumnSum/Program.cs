

int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];

int[,] matrix = ReadMatrix(rows, cols, " ");


for (int col = 0; col < matrix.GetLength(1); col++)
{
    //Console.WriteLine($"{col+1} column: ");
    int colSum = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        colSum += matrix[row, col];
        //Console.Write($"{matrix[row,col]} ");
    }

    Console.WriteLine(colSum);
    //Console.WriteLine();
}




int[,] ReadMatrix(int rows, int cols, string separator)
{
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int[] rowArray = Console.ReadLine().Split(separator).Select(int.Parse).ToArray();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = rowArray[col];
        }
    }

    return matrix;
}