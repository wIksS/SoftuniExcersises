

int n = int.Parse(Console.ReadLine());

char[,] matrix = ReadMatrix(n, n);
int currentRow = 0;
int currentCol = 0;
for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        if (matrix[row,col] == 'S')
        {
            currentRow = row;
            currentCol = col;
            break;
        }
    }
}

string command = Console.ReadLine();
int caughtFish = 0;

while (command != "collect the nets")
{
    matrix[currentRow, currentCol] = '-';
    Direction direction = (Direction)Enum.Parse(typeof(Direction), command);
    switch (direction)
    {
        case Direction.down:
            currentRow++;
            if (currentRow >= n)
            {
                currentRow = 0;
            }
            break;
        case Direction.up:
            currentRow--;
            if (currentRow < 0)
            {
                currentRow = n - 1;
            }
            break;
        case Direction.left:
            currentCol--;
            if (currentCol < 0)
            {
                currentCol = n - 1;
            }
            break;
        case Direction.right:
            currentCol++;
            if (currentCol >= n)
            {
                currentCol = 0;
            }
            break;
        default:break;
    }

    if (matrix[currentRow,currentCol] != '-')
    {
        if (matrix[currentRow,currentCol] == 'W')
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currentRow},{currentCol}]");
            return;
        }
        else
        {
            caughtFish += int.Parse(matrix[currentRow, currentCol].ToString());
        }
    }

    matrix[currentRow,currentCol] = 'S';

    //PrintMatrix(matrix, symbol => { Console.Write(symbol); });
    //Console.WriteLine("\n\n");

    command = Console.ReadLine();
}

if (caughtFish < 20)
{
    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20-caughtFish} tons of fish more.");
}
else
{
    Console.WriteLine("Success! You managed to reach the quota!");
}


if(caughtFish>0)
    Console.WriteLine($"Amount of fish caught: {caughtFish} tons.");


PrintMatrix(matrix, symbol =>
{
    Console.Write(symbol);
});

char[,] ReadMatrix(int rows, int cols)
{
    char[,] matrix = new char[n, n];

    for (int row = 0; row < n; row++)
    {
        string line = Console.ReadLine();
        for (int col = 0; col < n; col++)
        {
            matrix[row, col] = line[col];
        }
    }

    return matrix;
}

void PrintMatrix<T>(T[,] matrix, Action<T> print)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            print(matrix[row, col]);
        }

        Console.WriteLine();
    }
}

enum Direction
{
    down,
    up,
    left,
    right
}