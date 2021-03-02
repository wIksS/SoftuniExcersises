using InheritanceLecture.Conctract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InheritanceLecture.Renderers
{
    public class TextRenderer : IRenderer
    {
        private string path;
        private char[,] board;

        public TextRenderer(string path)
        {
            this.path = path;
            board = new char[70, 70];
            Clear();
        }

        public void Clear()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = ' ';
                }
            }
        }



        public void Write(string message)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(message);
            }
        }

        public void WriteAtPosition(string message, Position position)
        {
            for (int i = 0; i < message.Length; i++)
            {
                board[position.X+i, position.Y] = message[i];
            }

            using (StreamWriter writer = new StreamWriter(path,false))
            {
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        writer.Write(board[row, col]);
                    }

                    writer.WriteLine();
                }
            }
        }

        public void WriteLine(string message)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(message);
            }
        }
    }
}
