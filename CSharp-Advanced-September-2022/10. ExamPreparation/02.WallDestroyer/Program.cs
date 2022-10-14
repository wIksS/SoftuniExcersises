using System;

namespace _02.WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int currentRow = 0;
            int currentCol = 0;


            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                    if (line[col] == 'V')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            string command = Console.ReadLine().ToLower();
            int holes = 1;
            int rods = 0;
            matrix[currentRow, currentCol] = '*';
            bool isElectricuted = false;

            while (command != "end")
            {
                int oldRow = currentRow;
                int oldCol = currentCol;
                switch (command)
                {
                    case "up":
                        currentRow--;
                        break;
                    case "down":
                        currentRow++;
                        break;
                    case "left":
                        currentCol--;
                        break;
                    case "right":
                        currentCol++;
                        break;
                    default:
                        break;
                }

                if (currentRow >= 0 && currentRow < n && currentCol >= 0 && currentCol < n)
                {
                    if (matrix[currentRow,currentCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rods++;
                        currentRow = oldRow;
                        currentCol = oldCol;
                    }
                    else if (matrix[currentRow,currentCol] == '-')
                    {
                        holes++;
                        matrix[currentRow,currentCol] = '*';
                    }
                    else if (matrix[currentRow,currentCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentCol}]!");
                    }
                    else if (matrix[currentRow,currentCol] == 'C')
                    {
                        matrix[currentRow, currentCol] = 'E';
                        isElectricuted = true;
                        holes++;
                        break;
                    }
                }
                else
                {
                    currentRow = oldRow;
                    currentCol = oldCol;
                }

                //Console.WriteLine(new String('-',55));
                //for (int row = 0; row < n; row++)
                //{
                //    for (int col = 0; col < n; col++)
                //    {
                //        Console.Write(matrix[row, col]);
                //    }

                //    Console.WriteLine();
                //}
                //Console.WriteLine($"Holes:{holes} POS: {currentRow},{currentCol}");
                //Console.WriteLine(new String('-', 55));

                command = Console.ReadLine().ToLower();
            }

            if (isElectricuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {rods} rod(s).");
                matrix[currentRow, currentCol] = 'V';
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
