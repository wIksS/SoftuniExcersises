

int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

Queue<int[]> bombs = new Queue<int[]>();

for (int row = 0; row < n; row++)
{
	int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
	for (int col = 0; col < n; col++)
	{
		matrix[row, col] = rowInput[col];
	}
}

//22,345 2,1 5,5
string[] bombsInput = Console.ReadLine().Split();
foreach (var bombInput in bombsInput)
{
	int[] bombCoord = bombInput.Split(",").Select(int.Parse).ToArray();

	bombs.Enqueue(bombCoord);
}

while (bombs.Count > 0)
{
	int[] bombCoordinate = bombs.Dequeue();
	int bombRow = bombCoordinate[0];
	int bombCol = bombCoordinate[1];

	if (matrix[bombRow, bombCol] <= 0)
	{
		continue;
	}

	AttackCell(matrix, bombRow, bombCol, bombRow - 1, bombCol);
    AttackCell(matrix, bombRow, bombCol, bombRow - 1, bombCol-1);
    AttackCell(matrix, bombRow, bombCol, bombRow - 1, bombCol+1);

    AttackCell(matrix, bombRow, bombCol, bombRow, bombCol - 1);
    AttackCell(matrix, bombRow, bombCol, bombRow , bombCol + 1);

    AttackCell(matrix, bombRow, bombCol, bombRow + 1, bombCol);
    AttackCell(matrix, bombRow, bombCol, bombRow + 1, bombCol - 1);
    AttackCell(matrix, bombRow, bombCol, bombRow + 1, bombCol + 1);

	matrix[bombRow, bombCol] = 0;
}

int aliveCellsCount = 0;
int aliveCellsSum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		if (matrix[row,col] > 0)
		{
			aliveCellsCount++;
			aliveCellsSum+= matrix[row,col];
		}
	}
}

Console.WriteLine($"Alive cells: {aliveCellsCount}");
Console.WriteLine($"Sum: {aliveCellsSum}");

PrintMatrix(matrix);

void AttackCell(int[,] matrix, int bombRow, int bombCol, int attackedRow, int attackedCol)
{
	if (attackedRow < 0 || attackedRow >= matrix.GetLength(0)
		|| attackedCol < 0 || attackedCol >= matrix.GetLength(1))
	{
		return;
	}


	if (matrix[attackedRow, attackedCol] > 0)
	{
		matrix[attackedRow, attackedCol] -= matrix[bombRow, bombCol];
	}
}

void PrintMatrix(int[,] matrix, string format = " ")
{

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
			if (col < matrix.GetLength(1) - 1)
			{
				Console.Write($"{matrix[row, col]}{format}");
			}
			else
			{
                Console.Write($"{matrix[row, col]}");
            }
        }

        Console.WriteLine();
    }
}