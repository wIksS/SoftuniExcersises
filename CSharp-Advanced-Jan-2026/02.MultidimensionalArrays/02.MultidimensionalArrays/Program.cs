
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];
char[,] matrix = new char[rows, cols];

string snake = Console.ReadLine();

string direction = "right";
int row = 0;
int col = -1;

int snakeIndex = 0;

for (int i = 0; i < rows * cols; i++)
{
    if (col == matrix.GetLength(1) - 1)
    {
        if (direction == "right")
        {
            row++;
            col++;
            direction = "left";
        }
    }
    if (col == 0)
    {
        if (direction == "left")
        {
            row++;
            col--;
            direction = "right";
        }
    }

    if (direction == "right")
    {
        col++;
    }
    if (direction == "left")
    {
        col--;
    }

    matrix[row, col] = snake[snakeIndex];
    snakeIndex++;
    if (snakeIndex == snake.Length)
    {
        snakeIndex = 0;
    }
}

PrintMatrix(matrix);

void PrintMatrix(char[,] matrix)
{

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]}");
        }

        Console.WriteLine();
    }
}