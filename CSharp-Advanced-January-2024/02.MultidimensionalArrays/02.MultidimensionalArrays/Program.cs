int[,] matrix = new int[4, 3];

matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;

matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;

matrix[2, 0] = 7;
matrix[2, 1] = 8;
matrix[2, 2] = 9;

matrix[3, 0] = 10;
matrix[3, 1] = 11;
matrix[3, 2] = 12;

Console.WriteLine(matrix[3,1]);

Console.SetCursorPosition(15, 5);

Console.WriteLine("This is a matrix !!");


int[][] array2D = new int[4][];

array2D[0] = new int[3] { 1, 2, 3 };
array2D[1] = new int[3] { 4, 5, 6};
array2D[2] = new int[3] { 7, 8, 9 };
array2D[3] = new int[3] { 10, 11, 12 };