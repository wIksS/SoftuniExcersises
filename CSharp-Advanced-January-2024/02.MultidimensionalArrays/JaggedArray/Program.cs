

int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[5] { 1, 2, 3, 4, 5 };
jaggedArray[1] = new int[2];
jaggedArray[2] = new int[3];


Console.WriteLine(jaggedArray.Length);
Console.WriteLine(jaggedArray[0].Length);
Console.WriteLine(jaggedArray[1].Length);
Console.WriteLine(jaggedArray[2].Length);



for (int row = 0; row < jaggedArray.Length; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col]+" ");
    }

    Console.WriteLine();
}