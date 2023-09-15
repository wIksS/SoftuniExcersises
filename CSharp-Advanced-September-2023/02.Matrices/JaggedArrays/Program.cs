

int[][] jagged = new int[3][];

jagged[0] = new int[3];
jagged[1] = new int[1];
jagged[2] = new int[3];

jagged[0][0] = 1;
jagged[0][1] = 2;
jagged[0][2] = 3;

jagged[1][0] = 4;

jagged[2][0] = 5;
jagged[2][1] = 6;
jagged[2][2] = 7;

//Console.WriteLine(jagged.Length);
//Console.WriteLine(jagged[0].Length);
//Console.WriteLine(jagged[1].Length);
//Console.WriteLine(jagged[2].Length);

for (int row = 0; row < jagged.Length; row++)
{
    for (int col = 0; col < jagged[row].Length; col++)
    {
        Console.Write($"{jagged[row][col]} ");
    }

    Console.WriteLine();
}
