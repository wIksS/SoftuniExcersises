

int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

int counter = 0;

int[,] matrix = new int[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = row * col;
    }
}
Console.WriteLine();
for (int i = 0; i < rows; i++)
{
    Console.Write(" " + matrix[i, i]);
}
Console.WriteLine();

for (int i = 0; i < rows; i++)
{
    Console.Write(" " + matrix[i, cols - i - 1]);
}
Console.WriteLine();

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] < 10 )
        {
            Console.Write($"  {matrix[row, col]} ");
        }
        else if (matrix[row, col] < 100)
        {
            Console.Write($" {matrix[row, col]} ");
        }
        else
        {
            Console.Write($"{matrix[row, col]} ");
        }
    }

    Console.WriteLine();
}
