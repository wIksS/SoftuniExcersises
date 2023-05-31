string[] input = Console.ReadLine().Split(", ");

int rows = int.Parse(input[0]);
int cols = int.Parse(input[1]);

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = array[col];
    }
}
