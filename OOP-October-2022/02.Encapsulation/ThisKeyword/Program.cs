using System;

namespace ThisKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drawer drawer = new Drawer();
            Board board = new Board();

            Drawer returnedDrawer = drawer.Paint(board);
            board.Paint(drawer);
        }
    }

    class Drawer
    {
        public Drawer Paint(Board board)
        {
            board.Paint(this);

            return this;
        }

        public void Draw()
        {

        }
    }

    class Board
    {
        public void Paint(Drawer drawer)
        {
            drawer.Draw();
        }
    }
}
