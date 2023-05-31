
int[] array = new int[3]
    {1,2,3 };

int[,] matrix = new int[3, 3]
    {
        { 1,2,3 },
        { 4,5,6 },
        { 7,8,9 }
    };

//Console.WriteLine(matrix[-1,2]);

int[][] matrixAsArray = new int[3][];

Console.WriteLine($"matrix[0,2] = {matrix[0, 2]}");
Console.WriteLine($"matrix[2,2] = {matrix[2, 2]}");


Console.WriteLine($"{String.Join(",",matrix)}");

Stack<int[,]> stack = new Stack<int[,]>();    