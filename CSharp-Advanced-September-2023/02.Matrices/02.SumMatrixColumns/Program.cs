
int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    //7, 1, 3, 3, 2, 1
    int[] rowValues = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowValues[col];
    }
}


for (int col = 0; col < cols; col++)
{
    int sum = 0;

    for (int row = 0; row < rows; row++)
    {
        //Console.Write(matrix[row,col]+" ");
        sum += matrix[row, col];
    }
    
    //Console.WriteLine();
    Console.WriteLine( sum);
}