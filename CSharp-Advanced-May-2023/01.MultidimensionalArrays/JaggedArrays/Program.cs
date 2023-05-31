

int[][] matrix = new int[3][];

matrix[0] = new int[2];

matrix[0][0] = 1;
matrix[0][1] = 2;


matrix[1] = new int[3];

matrix[1][0] = 4;
matrix[1][1] = 5;
matrix[1][2] = 6;

matrix[2] = new int[1];

matrix[2][0] = 7;


//int[,] csharpMatrix = new int[3, 3];
//int[] row1 = csharpMatrix[1];
int[] row2 = matrix[2];

for (int row = 0; row < matrix.Length; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        Console.Write(matrix[row][col] + " ");
    }

    Console.WriteLine();
}
