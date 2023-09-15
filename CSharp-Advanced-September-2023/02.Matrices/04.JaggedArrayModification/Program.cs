int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
    matrix[row] = rowValues;
}


string command = Console.ReadLine().ToLower();

while (command != "end")
{
    //Add 0 0 5

    string[] input = command.Split();
    int row = int.Parse(input[1]);
    int col = int.Parse(input[2]);
    int value = int.Parse(input[3]);

    if (row < 0 || col < 0 || row >= matrix.Length || matrix[row].Length <= col)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else
    {
        if (input[0] == "add")
        {
            matrix[row][col] += value;
        }
        else
        {
            matrix[row][col] -= value;
        }
    }

    command = Console.ReadLine().ToLower();
}


for (int row = 0; row < matrix.Length; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        Console.Write($"{matrix[row][col]} ");
    }

    Console.WriteLine();
}