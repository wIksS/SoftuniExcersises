int n = int.Parse(Console.ReadLine());

Queue<string> commands = new Queue<string>(Console.ReadLine().Split());

char[,] matrix = new char[n, n];
int coals = 0;
int minerRow = 0;
int minerCol = 0;
int collectedCoals = 0;
bool isExit = false;
for (int row = 0; row < n; row++)
{
    string[] rowInput = Console.ReadLine().Split();

    for (int col = 0; col < rowInput.Length; col++)
    {

        matrix[row, col] = rowInput[col][0];
        if (matrix[row, col] == 'c')
        {
            coals++;
        }

        if (matrix[row, col] == 's')
        {
            minerRow = row;
            minerCol = col;
        }
    }
}

while (commands.Count > 0)
{
    string direction = commands.Dequeue();

    switch (direction)
    {
        case "up":
            if (IsPositionValid(matrix, minerRow - 1, minerCol))
            {
                minerRow--;
            }
            break;
        case "down":
            if (IsPositionValid(matrix, minerRow + 1, minerCol))
            {
                minerRow++;
            }
            break;
        case "left":
            if (IsPositionValid(matrix, minerRow, minerCol - 1))
            {
                minerCol--;
            }
            break;
        case "right":
            if (IsPositionValid(matrix, minerRow, minerCol + 1))
            {
                minerCol++;
            }
            break;
        default:
            break;
    }

    if (matrix[minerRow, minerCol] == 'c')
    {
        matrix[minerRow, minerCol] = '*';
        collectedCoals++;

        if (coals - collectedCoals == 0)
        {
            break;
        }
    }
    if (matrix[minerRow, minerCol] == 'e')
    {
        isExit = true;
        break;
    }

}

if (coals - collectedCoals == 0)
{
    Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
}
else if (isExit)
{
    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
}
else
{
    Console.WriteLine($"{coals-collectedCoals} coals left. ({minerRow}, {minerCol})");
}

bool IsPositionValid(char[,] matrix, int row, int col)
{
    if (row < 0 || row >= matrix.GetLength(0) ||
        col < 0 || col >= matrix.GetLength(1))
    {
        return false;
    }

    return true;
}