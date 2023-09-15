
int rows = 9;
int cols = 12;
int[,] matrix = new int[rows, cols];

// 1,2,3
// 4,5,6
// 7,8,9

// [[1,2,3],[4,5,6],[7,8,9]

int index = 1;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = row * col; 
    }
}

//foreach (var item in matrix)
//{
//    Console.WriteLine(item);
//}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        // _9 _3 10
        // 10
        if (matrix[row,col] < 10)
        {
            Console.Write(" " + matrix[row, col] + " ");

        }
        else 
            Console.Write(matrix[row, col] + " ");
    }

    Console.WriteLine();
}

