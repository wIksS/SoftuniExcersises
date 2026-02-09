string[] input = Console.ReadLine().Split();

int rows = int.Parse(input[0]);
int cols = int.Parse(input[1]);

char[,] matrix = new char[rows, cols];
int boyRow = 0;
int boyCol = 0;

int initialRow = 0;
int initialCol = 0;

for (int row = 0; row < rows; row++)
{
    string line = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        if (line[col] == 'B')
        {
            boyRow = row;
            boyCol = col;
            initialRow = row;
            initialCol = col;
        }

        matrix[row, col] = line[col];
    }
}

bool isSuccess = false;

while (true)
{
    string command = Console.ReadLine();
    int oldRow = boyRow;
    int oldCol = boyCol;

    switch (command)
    {
        case "down":
            boyRow++;
            break;
        case "up":
            boyRow--;
            break;
        case "right":
            boyCol++;
            break;
        case "left":
            boyCol--;
            break;
        default:
            break;
    }

    if (!IsPositionValid(matrix, boyRow, boyCol))
    {
        Console.WriteLine("The delivery is late. Order is canceled.");
        break;
    }

    if (matrix[boyRow, boyCol] == '*')
    {
        boyRow = oldRow;
        boyCol = oldCol;
    }
    else if (matrix[boyRow, boyCol] == 'P')
    {
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        matrix[boyRow, boyCol] = 'R';
    }
    else if (matrix[boyRow, boyCol] == 'A')
    {
        Console.WriteLine("Pizza is delivered on time! Next order...");
        isSuccess = true;
        matrix[boyRow, boyCol] = 'P';
        break;
    }
    else
    {
        matrix[boyRow, boyCol] = '.';
    }

    //PrintMatrix(matrix, "{0}");
}

if (isSuccess)
{
    matrix[initialRow, initialCol] = 'B';
}
else
{
    matrix[initialRow, initialCol] = ' ';
}

PrintMatrix(matrix, "{0}");

bool IsPositionValid<T>(T[,] matrix, int row, int col)
{
    return !(row < 0 || row >= matrix.GetLength(0)
        || col < 0 || col >= matrix.GetLength(1));
}

void PrintMatrix<T>(T[,] matrix, string format)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(String.Format(format, matrix[row, col]));
        }

        Console.WriteLine();
    }
}

char[,] ReadCharMatrix(int rows, int cols)
{
    char[,] matrix = new char[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string line = Console.ReadLine();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = line[col];
        }
    }

    return matrix;
}