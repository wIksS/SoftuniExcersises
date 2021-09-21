namespace XonixGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.IO;

    public class Cell
    {
        private int row, col;

        public int Row
        {
            get { return row; }
        }

        public int Col
        {
            get { return col; }
        }

        public Cell(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    public class Xonix
    {
        // Console
        static int gameFieldWidth = 100;
        static int gameFieldHeight = 30;

        // Xonix
        static char xonixSymbol = '\u263A';
        static ConsoleColor xonixColor = ConsoleColor.DarkCyan;
        static int xonixRow = 0;
        static int xonixCol = 0;
        static int previousXonixRow = xonixRow;
        static int previousXonixCol = xonixCol;
        static string xonixDirection = string.Empty;
        static string previousXonixDirection = string.Empty;

        // Bad boys
        static char badBoysSymbol = '\u263B';
        static int numberOfBadBoys = 1;
        static int[] badBoysCol = new int[numberOfBadBoys];
        static int[] badBoysRow = new int[numberOfBadBoys];
        static ConsoleColor badBoysColor = ConsoleColor.Red;
        static int[] previousBadBoysCol = new int[numberOfBadBoys];
        static int[] previousBadBoysRow = new int[numberOfBadBoys];
        static Random randomGenerator = new Random();
        static string[] badBoysDirection = new string[numberOfBadBoys];

        // Filling
        static bool xonixIsInsideField = false;
        static bool[,] visited = new bool[gameFieldHeight, gameFieldWidth];
        static bool[,] tempVisited = new bool[gameFieldHeight, gameFieldWidth];

        // Scores
        static int lives = 2;
        static int score = 0;
        static int percents = 0;

        static void SetConsole()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.CursorVisible = false;
                Console.WindowHeight = gameFieldHeight + 1;
                Console.WindowWidth = gameFieldWidth;
                RemoveScrollBars();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                throw new ArgumentOutOfRangeException("Your screen resolution is too small or your console font size is too big", exception);
            }
        }

        static void RemoveScrollBars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        static void InitialPosition()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < gameFieldWidth; i++)
            {
                visited[0, i] = true;
                Console.SetCursorPosition(i, 0);
                Console.Write(" ");
                visited[gameFieldHeight - 1, i] = true;
                Console.SetCursorPosition(i, gameFieldHeight - 1);
                Console.Write(" ");
            }

            for (int i = 0; i < gameFieldHeight; i++)
            {
                visited[i, 0] = true;
                Console.SetCursorPosition(0, i);
                Console.Write(" ");
                visited[i, gameFieldWidth - 1] = true;
                Console.SetCursorPosition(gameFieldWidth - 1, i);
                Console.Write(" ");
            }

            tempVisited = CopyMatrix(visited);

            Console.BackgroundColor = ConsoleColor.Black;

            DrawXonix();
            DrawBadBoys();
            DrawResults();
        }

        static void PrintAtPosition(int row, int col, char symbol, ConsoleColor forgroundColor, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            Console.ForegroundColor = forgroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }

        static void DrawXonix()
        {
            PrintAtPosition(xonixRow, xonixCol, xonixSymbol, xonixColor, ConsoleColor.Yellow);
        }

        static void DrawBadBoys()
        {
            for (int i = 0; i < numberOfBadBoys; i++)
            {
                do
                {
                    badBoysRow[i] = randomGenerator.Next(1, gameFieldHeight - 2);
                    badBoysCol[i] = randomGenerator.Next(1, gameFieldWidth - 2);
                }
                while (visited[badBoysRow[i], badBoysCol[i]]);

                previousBadBoysRow[i] = badBoysRow[i];
                previousBadBoysCol[i] = badBoysCol[i];
                badBoysDirection[i] = "SE";
                PrintAtPosition(badBoysRow[i], badBoysCol[i], badBoysSymbol, badBoysColor);
            }
        }

        static void DrawResults()
        {
            Console.SetCursorPosition(0, gameFieldHeight);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Score: {0,5}   Percentage: {1,2}%   Lives: {2}", score, percents, lives);
        }

        static void MoveXonixOnHisGround()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    xonixDirection = "S";
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    xonixDirection = "N";
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    xonixDirection = "E";
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    xonixDirection = "W";
                }

                previousXonixRow = xonixRow;
                previousXonixCol = xonixCol;

                switch (xonixDirection)
                {
                    case "S":
                        if (xonixRow < gameFieldHeight - 1)
                        {
                            xonixRow++;
                        }
                        break;
                    case "N":
                        if (xonixRow > 0)
                        {
                            xonixRow--;
                        }
                        break;
                    case "E":
                        if (xonixCol < gameFieldWidth - 1)
                        {
                            xonixCol++;
                        }
                        break;
                    case "W":
                        if (xonixCol > 0)
                        {
                            xonixCol--;
                        }
                        break;
                }

                if (xonixRow != previousXonixRow || xonixCol != previousXonixCol)
                {
                    if (visited[xonixRow, xonixCol])
                    {
                        PrintAtPosition(xonixRow, xonixCol, xonixSymbol, xonixColor, ConsoleColor.Yellow);

                        Console.SetCursorPosition(previousXonixCol, previousXonixRow);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                    }
                    else
                    {
                        xonixRow = previousXonixRow;
                        xonixCol = previousXonixCol;
                        PrintAtPosition(xonixRow, xonixCol, xonixSymbol, xonixColor, ConsoleColor.Yellow);
                        xonixIsInsideField = true;
                        previousXonixDirection = xonixDirection;
                    }
                }
            }
        }

        static void MoveXonixOnField()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (keyInfo.Key == ConsoleKey.DownArrow && previousXonixDirection != "N")
                {
                    xonixDirection = "S";
                    previousXonixDirection = "S";
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow && previousXonixDirection != "S")
                {
                    xonixDirection = "N";
                    previousXonixDirection = "N";
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow && previousXonixDirection != "W")
                {
                    xonixDirection = "E";
                    previousXonixDirection = "E";
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow && previousXonixDirection != "E")
                {
                    xonixDirection = "W";
                    previousXonixDirection = "W";
                }
            }

            previousXonixRow = xonixRow;
            previousXonixCol = xonixCol;

            switch (xonixDirection)
            {
                case "S": xonixRow++; break;
                case "N": xonixRow--; break;
                case "E": xonixCol++; break;
                case "W": xonixCol--; break;
            }

            if (!visited[xonixRow, xonixCol] && tempVisited[xonixRow, xonixCol])
            {
                lives--;
                if (lives >= 0)
                {
                    LoseLives();
                }
                else
                {
                    PrintGameOver();
                }
            }

            tempVisited[xonixRow, xonixCol] = true;
            PrintAtPosition(xonixRow, xonixCol, xonixSymbol, xonixColor, ConsoleColor.Yellow);

            Console.SetCursorPosition(previousXonixCol, previousXonixRow);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");

            if (visited[xonixRow, xonixCol])
            {
                RunDfs();
                tempVisited = CopyMatrix(visited);
                xonixIsInsideField = false;
            }
        }

        static void MoveBadBoys()
        {
            for (int i = 0; i < numberOfBadBoys; i++)
            {
                switch (badBoysDirection[i])
                {
                    case "SE": badBoysRow[i]++; badBoysCol[i]++; break;
                    case "SW": badBoysRow[i]++; badBoysCol[i]--; break;
                    case "NE": badBoysRow[i]--; badBoysCol[i]++; break;
                    case "NW": badBoysRow[i]--; badBoysCol[i]--; break;
                }

                if (badBoysDirection[i] == "SE")
                {
                    if (visited[badBoysRow[i] + 1, badBoysCol[i]] && visited[badBoysRow[i], badBoysCol[i] + 1])
                    {
                        badBoysDirection[i] = "NW";
                    }
                    else if (visited[badBoysRow[i] + 1, badBoysCol[i]])
                    {
                        badBoysDirection[i] = "NE";
                    }
                    else if (visited[badBoysRow[i], badBoysCol[i] + 1])
                    {
                        badBoysDirection[i] = "SW";
                    }
                }
                else if (badBoysDirection[i] == "SW")
                {
                    if (visited[badBoysRow[i] + 1, badBoysCol[i]] && visited[badBoysRow[i], badBoysCol[i] - 1])
                    {
                        badBoysDirection[i] = "NE";
                    }
                    else if (visited[badBoysRow[i] + 1, badBoysCol[i]])
                    {
                        badBoysDirection[i] = "NW";
                    }
                    else if (visited[badBoysRow[i], badBoysCol[i] - 1])
                    {
                        badBoysDirection[i] = "SE";
                    }
                }
                else if (badBoysDirection[i] == "NE")
                {
                    if (visited[badBoysRow[i] - 1, badBoysCol[i]] && visited[badBoysRow[i], badBoysCol[i] + 1])
                    {
                        badBoysDirection[i] = "SW";
                    }
                    else if (visited[badBoysRow[i] - 1, badBoysCol[i]])
                    {
                        badBoysDirection[i] = "SE";
                    }
                    else if (visited[badBoysRow[i], badBoysCol[i] + 1])
                    {
                        badBoysDirection[i] = "NW";
                    }
                }
                else if (badBoysDirection[i] == "NW")
                {
                    if (visited[badBoysRow[i] - 1, badBoysCol[i]] && visited[badBoysRow[i], badBoysCol[i] - 1])
                    {
                        badBoysDirection[i] = "SE";
                    }
                    else if (visited[badBoysRow[i] - 1, badBoysCol[i]])
                    {
                        badBoysDirection[i] = "SW";
                    }
                    else if (visited[badBoysRow[i], badBoysCol[i] - 1])
                    {
                        badBoysDirection[i] = "NE";
                    }
                }

                PrintAtPosition(badBoysRow[i], badBoysCol[i], badBoysSymbol, badBoysColor);

                Console.SetCursorPosition(previousBadBoysCol[i], previousBadBoysRow[i]);
                Console.Write(" ");

                if (!visited[badBoysRow[i], badBoysCol[i]] && tempVisited[badBoysRow[i], badBoysCol[i]])
                {
                    lives--;
                    if (lives >= 0)
                    {
                        LoseLives();
                    }
                    else
                    {
                        PrintGameOver();
                    }
                }

                previousBadBoysRow[i] = badBoysRow[i];
                previousBadBoysCol[i] = badBoysCol[i];
            }
        }

        static void LoseLives()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Yellow;

            for (int row = 0; row < gameFieldHeight; row++)
            {
                for (int col = 0; col < gameFieldWidth; col++)
                {
                    if (visited[row, col])
                    {
                        Console.SetCursorPosition(col, row);
                        Console.Write(" ");
                    }
                }
            }

            Console.BackgroundColor = ConsoleColor.Black;

            tempVisited = CopyMatrix(visited);

            xonixRow = 0;
            xonixCol = 0;
            previousXonixRow = xonixRow;
            previousXonixCol = xonixCol;
            xonixDirection = string.Empty;
            previousXonixDirection = string.Empty;

            DrawXonix();
            DrawBadBoys();
            DrawResults();
        }

        static void PrintGameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            StreamReader gameOverFile = new StreamReader("../../gameover.txt");
            string gameOverString = gameOverFile.ReadToEnd();
            gameOverFile.Close();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(gameOverString);
            Environment.Exit(0);
        }

        static void RunDfs()
        {
            for (int row = 0; row < gameFieldHeight; row++)
            {
                for (int col = 0; col < gameFieldWidth; col++)
                {
                    Dfs(row, col);
                }
            }

        }

        static bool[,] CopyMatrix(bool[,] visited)
        {
            bool[,] boolMatrix = new bool[gameFieldHeight, gameFieldWidth];
            for (int row = 0; row < gameFieldHeight; row++)
            {
                for (int col = 0; col < gameFieldWidth; col++)
                {
                    boolMatrix[row, col] = visited[row, col];
                }
            }

            return boolMatrix;
        }

        static void Dfs(int row, int col)
        {
            if (!tempVisited[row, col])
            {
                Stack<Cell> cells = new Stack<Cell>();
                cells.Push(new Cell(row, col));
                while (cells.Count != 0)
                {
                    Cell currentCell = cells.Pop();
                    tempVisited[currentCell.Row, currentCell.Col] = true;
                    if (ValidCell(currentCell.Row + 1, currentCell.Col) && !tempVisited[currentCell.Row + 1, currentCell.Col]
                        && !cells.Any(cell => cell.Row == currentCell.Row + 1 && cell.Col == currentCell.Col))
                    {
                        cells.Push(new Cell(currentCell.Row + 1, currentCell.Col));
                    }

                    if (ValidCell(currentCell.Row, currentCell.Col + 1) && !tempVisited[currentCell.Row, currentCell.Col + 1]
                        && !cells.Any(cell => cell.Row == currentCell.Row && cell.Col == currentCell.Col + 1))
                    {
                        cells.Push(new Cell(currentCell.Row, currentCell.Col + 1));
                    }

                    if (ValidCell(currentCell.Row - 1, currentCell.Col) && !tempVisited[currentCell.Row - 1, currentCell.Col]
                        && !cells.Any(cell => cell.Row == currentCell.Row - 1 && cell.Col == currentCell.Col))
                    {
                        cells.Push(new Cell(currentCell.Row - 1, currentCell.Col));
                    }

                    if (ValidCell(currentCell.Row, currentCell.Col - 1) && !tempVisited[currentCell.Row, currentCell.Col - 1]
                        && !cells.Any(cell => cell.Row == currentCell.Row && cell.Col == currentCell.Col - 1))
                    {
                        cells.Push(new Cell(currentCell.Row, currentCell.Col - 1));
                    }
                }

                if (CheckForBadBoys())
                {
                    FillMatrix(false);
                }
                else
                {
                    FillMatrix(true);
                }
            }
        }

        static bool CheckForBadBoys()
        {
            bool result = false;
            for (int i = 0; i < numberOfBadBoys; i++)
            {
                result = tempVisited[badBoysRow[i], badBoysCol[i]];
            }
            return result;
        }

        static void FillMatrix(bool element)
        {
            for (int row = 0; row < gameFieldHeight; row++)
            {
                for (int col = 0; col < gameFieldWidth; col++)
                {
                    if (tempVisited[row, col] == element)
                    {
                        Console.SetCursorPosition(col, row);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        visited[row, col] = true;
                    }
                }
            }

            int countFullCells = 0;
            int fullPercent = (gameFieldHeight - 2) * (gameFieldWidth - 2);

            for (int row = 0; row < gameFieldHeight; row++)
            {
                for (int col = 0; col < gameFieldWidth; col++)
                {
                    if (visited[row, col])
                    {
                        countFullCells++;
                    }
                }
            }
            score = countFullCells - (gameFieldHeight * 2 + (gameFieldWidth - 2) * 2);
            percents = (countFullCells - (gameFieldHeight * 2 + (gameFieldWidth - 2) * 2)) * 100 / fullPercent;
            if (percents < 80)
            {
                DrawResults();
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                StreamReader youWinFile = new StreamReader("../../youwin.txt");
                string youWinString = youWinFile.ReadToEnd();
                youWinFile.Close();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(youWinString);
                Environment.Exit(0);
            }
        }
        static bool ValidCell(int row, int col)
        {
            return row >= 0 && col >= 0 && row < gameFieldHeight && col < gameFieldWidth;
        }

        static void Main()
        {
            try
            {
                SetConsole();
                InitialPosition();

                while (true)
                {
                    if (!xonixIsInsideField)
                    {
                        MoveXonixOnHisGround();
                    }
                    else
                    {
                        MoveXonixOnField();
                    }

                    MoveBadBoys();
                    Thread.Sleep(60);
                }
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
        }
    }
}