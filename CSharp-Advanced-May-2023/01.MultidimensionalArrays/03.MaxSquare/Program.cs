string[] input = Console.ReadLine().Split(", ");

int rows = int.Parse(input[0]);
int cols = int.Parse(input[1]);

int[,] matrix = new int[rows, cols];

//3, 6
//7, 1, 3, 3, 2, 1
//1, 3, 9, 8, 8, 9
//4, 6, 7, 9, 7, 9


for (int row = 0; row < rows; row++)
{
    int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = array[col];
    }
}

int maxSum = int.MinValue;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < rows-1; row++)
{
    for (int col = 0; col < cols-1; col++) // col = 1
    {
        int currentSum = 0;
        currentSum+= matrix[row, col];
        currentSum += matrix[row, col + 1];
        currentSum += matrix[row + 1, col];
        currentSum += matrix[row + 1, col + 1];

        if (currentSum >= maxSum)
        {
            maxRow = row;
            maxCol = col;
            maxSum = currentSum;
        }
    }
}

Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow +1, maxCol + 1]}");
Console.WriteLine(maxSum);