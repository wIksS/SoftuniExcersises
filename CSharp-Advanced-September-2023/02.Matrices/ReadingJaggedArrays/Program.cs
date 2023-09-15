
int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
    matrix[row] = rowValues;
}

for (int row = 0; row < matrix.Length; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        Console.Write($"{matrix[row][col]} ");
    }

    Console.WriteLine();
}


foreach (int[] row in matrix)
{
    for (int col = 0; col < row.Length; col++)
    {
        Console.Write(row[col]);
    }

    Console.WriteLine();
}