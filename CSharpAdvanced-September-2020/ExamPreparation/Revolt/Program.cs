using System;

namespace Revolt
{
    class Program
    {
        public class Position
        {
            public Position(int row, int col)
            {
                Col = col;
                Row = row;
            }

            public int Row { get; set; }

            public int Col { get; set; }

            public bool IsSafe(int rowCount, int colCount)
            {
                if (Row < 0 || Col < 0)
                {
                    return false;
                }
                if (Row >= rowCount || Col >= colCount)
                {
                    return false;
                }

                return true;
            }

            public void CheckOtherSideMovement(int rowCount, int colCount)
            {
                if (Row < 0)
                {
                    Row = rowCount - 1;
                }
                if (Col < 0)
                {
                    Col = colCount - 1;
                }
                if (Row >= rowCount)
                {
                    Row = 0;
                }
                if (Col >= colCount)
                {
                    Col = 0;
                }
            }

            public static Position GetDirection(string command)
            {
                int row = 0;
                int col = 0;
                if (command == "left")
                {
                    col = -1;
                }
                if (command == "right")
                {
                    col = 1;
                }
                if (command == "up")
                {
                    row = -1;
                }
                if (command == "down")
                {
                    row = 1;
                }

                return new Position(row, col);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commands = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            Read(matrix);
            var player = GetPlayerPosition(matrix);
            if (commands > 0)
            {
                matrix[player.Row, player.Col] = '-';
            }
            for (int i = 0; i < commands; i++)
            {
                string command = Console.ReadLine();

                MovePlayer(player, command, n);
                while (matrix[player.Row, player.Col] == 'B')
                {
                    MovePlayer(player, command, n);
                }

                while (matrix[player.Row, player.Col] == 'T')
                {
                    Position direction = Position.GetDirection(command);
                    player.Row += direction.Row * -1;
                    player.Col += direction.Col * -1;
                }

                if (matrix[player.Row,player.Col] == 'F')
                {
                    Console.WriteLine($"Player won!");
                    matrix[player.Row, player.Col] = 'f';
                    Print(matrix);
                    return;
                }
            }

            Console.WriteLine($"Player lost!");
            matrix[player.Row, player.Col] = 'f';
            Print(matrix);
        }

        static Position MovePlayer(Position player, string command, int n)
        {
            Position movement = Position.GetDirection(command);
            player.Row += movement.Row;
            player.Col += movement.Col;
            player.CheckOtherSideMovement(n, n);
            
            return player;
        }

        static Position GetPlayerPosition(char[,] matrix)
        {
            Position position = null;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == 'f')
                    {
                        position = new Position(row, col);
                    }
                }
            }

            return position;
        }

        private static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void Read(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
