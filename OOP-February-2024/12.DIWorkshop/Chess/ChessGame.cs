using Chess.Drawers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    //class Driver
    //{
    //    private IDrivable drivable;
    //}
    public class ChessGame
    {
        private IDrawer drawer;
        private Pawn[] pawns = new Pawn[8];

        public ChessGame(IDrawer drawer)
        {
            this.drawer = drawer;

            for (int i = 0; i < 8; i++)
            {
                pawns[i] = new Pawn(drawer);
            }
        }

        public void Start()
        {
            while (true)
            {
                foreach (var pawn in pawns)
                {
                    pawn.Draw();
                }

                drawer.WriteLine("");
                drawer.WriteLine("-----------");
                drawer.WriteLine("-----------");
                drawer.WriteLine("-----------");
                drawer.WriteLine("-----------");
                drawer.WriteLine("-----------");
                drawer.WriteLine("-----------");
                drawer.WriteLine("-----------");
                foreach (var pawn in pawns)
                {
                    pawn.Draw();
                }
                Thread.Sleep(1000);
            }
        }
    }
}
