int[,] matrix = new int[4, 4]
{
    { 1,  2, 3, 4},
    { 4,  5, 6, 4},
    { 7,  8, 9, 4},
    { 10,11,12, 4},
};


for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write(matrix[i,i]+ " ");
}
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write(matrix[i, matrix.GetLength(1) -i -1] + " ");
}