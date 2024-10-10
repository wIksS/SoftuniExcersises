int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

int beeRow = 0;
int beeCol = 0;

for (int row = 0; row < n; row++)
{
    string rowInput = Console.ReadLine();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = rowInput[col];
        if (rowInput[col] == 'B')
        {
            beeRow = row;
            beeCol = col;
        }
    }
}

int nectar = 0;
int energy = 15;
bool canRestore = true;
bool isHiveReached = false;

while (true)
{
    matrix[beeRow, beeCol] = '-';

    energy--;
    //Thread.Sleep(100);
    //Console.Clear();

    string command = Console.ReadLine();
    Direction direction = (Direction)Enum.Parse(typeof(Direction), command);

    switch (direction)
    {
        case Direction.down:
            beeRow++;
            if (beeRow == matrix.GetLength(0))
                beeRow = 0;    
            break;
        case Direction.right:
            beeCol++;
            if (beeCol == matrix.GetLength(1))
                beeCol = 0;
            break;
        case Direction.up:
            beeRow--;
            if(beeRow == -1)
                beeRow = matrix.GetLength(0) - 1;
            break;
        case Direction.left:
            beeCol--;
            if (beeCol == -1)
                beeCol = matrix.GetLength(1) - 1;
            break;
        default:
            break;
    }

    if (Char.IsDigit(matrix[beeRow, beeCol]))
    {
        nectar += int.Parse(matrix[beeRow,beeCol].ToString()); 
    }
    else if (matrix[beeRow,beeCol] == 'H')
    {
        isHiveReached = true;
        break;
    }

    if (energy <= 0)
    {
        if (nectar <= 30 || !canRestore)
        {
            break;
        }
        else
        {
            energy += nectar - 30;
            nectar = 30;
            canRestore = false;
        }
    }

    // matrix[beeRow, beeCol] = 'B';
    //PrintMatrix(matrix, ch => Console.Write(ch + " "));
}

if (isHiveReached && nectar >= 30)
{
    Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
}
else if (isHiveReached)
{
    Console.WriteLine($"Beesy did not manage to collect enough nectar.");
}
else
{
    Console.WriteLine($"This is the end! Beesy ran out of energy.");
}

matrix[beeRow, beeCol] = 'B';

PrintMatrix(matrix, c => Console.Write(c));

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
    right,
    up,
    left
}
