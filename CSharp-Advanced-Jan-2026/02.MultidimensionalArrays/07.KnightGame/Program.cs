int n = int.Parse(Console.ReadLine());

char[,] board = new char[n, n];

for (int row = 0; row < n; row++)
{
    string rowInput = Console.ReadLine();
    for (int col = 0; col < n; col++)
    {
        board[row, col] = rowInput[col];
    }
}

int removedKnights = 0;

while (true)
{
    int maxAttackedKnights = 0;
    int maxAttackRow = -1;
    int maxAttackCol = -1;

    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < n; col++)
        {
            if (board[row, col] == 'K')
            {
                int attackedKnights = GetAttackedKnights(board, row, col);
                if (attackedKnights > maxAttackedKnights)
                {
                    maxAttackRow = row;
                    maxAttackCol = col;
                    maxAttackedKnights = attackedKnights;
                }
            }
        }
    }

    if (maxAttackedKnights > 0)
    {
        board[maxAttackRow, maxAttackCol] = '0';
        removedKnights++;
    }
    else
    {
        break;
    }
}

Console.WriteLine(removedKnights);

//PrintMatrix(board);

int GetAttackedKnights(char[,] board, int knightRow, int knightCol)
{
    int attackedKnights = 0;

    attackedKnights += IsKnightAtPosition(board, knightRow - 2, knightCol + 1);
    attackedKnights += IsKnightAtPosition(board, knightRow - 2, knightCol - 1);

    attackedKnights += IsKnightAtPosition(board, knightRow + 2, knightCol + 1);
    attackedKnights += IsKnightAtPosition(board, knightRow + 2, knightCol - 1);


    attackedKnights += IsKnightAtPosition(board, knightRow + 1, knightCol + 2);
    attackedKnights += IsKnightAtPosition(board, knightRow - 1, knightCol + 2);


    attackedKnights += IsKnightAtPosition(board, knightRow + 1, knightCol - 2);
    attackedKnights += IsKnightAtPosition(board, knightRow - 1, knightCol - 2);

    return attackedKnights;
}


int IsKnightAtPosition(char[,] board, int attackedRow, int attackedCol)
{
    if (!IsPositionValid(board, attackedRow, attackedCol))
    {
        return 0;
    }

    if (board[attackedRow, attackedCol] == 'K')
    {
        return 1;
    }

    return 0;
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