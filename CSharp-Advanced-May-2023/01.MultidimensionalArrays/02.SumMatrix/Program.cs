string[] input = Console.ReadLine().Split(", ");

int rows = int.Parse(input[0]);
int cols = int.Parse(input[1]);

int[,] matrix = new int[rows, cols];

//    3, 6
//    7, 1, 3, 3, 2, 1
//    1, 3, 9, 8, 5, 6
//    4, 6, 7, 9, 1, 0


for (int row = 0; row < rows; row++)
{
    int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = array[col];
    }
}

int sum = 0;
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        sum += matrix[row, col];
    }
}

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);