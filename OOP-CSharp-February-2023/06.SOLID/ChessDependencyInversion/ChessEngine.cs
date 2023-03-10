using ChessDependencyInversion.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDependencyInversion
{
    public class ChessEngine
    {
        private List<Piece> whitePieces;
        private List<Piece> blackPieces;
        private IRenderer renderer;
        
        public ChessEngine(IRenderer renderer)
        {
            this.renderer = renderer;

            whitePieces = new List<Piece>()
            {
                new Piece('R'),
                new Piece('k'),
                new Piece('B'),
                new Piece('Q'),
                new Piece('K'),
                new Piece('B'),
                new Piece('k'),
                new Piece('R'),
            };

            for (int i = 0; i < 8; i++)
            {
                whitePieces.Add(new Piece('P'));
            }

            blackPieces = new List<Piece>()
            {
                new Piece('R'),
                new Piece('k'),
                new Piece('B'),
                new Piece('Q'),
                new Piece('K'),
                new Piece('B'),
                new Piece('k'),
                new Piece('R'),
            };

            for (int i = 0; i < 8; i++)
            {
                blackPieces.Add(new Piece('P'));
            }

        }
        public void Start()
        {
            while (true)
            {
                renderer.WriteLine("Chess board");
                renderer.WriteLine("White pieces:");
                foreach (var piece in whitePieces)
                {
                    piece.Draw(renderer);
                }

                renderer.WriteLine("");
                renderer.WriteLine("Black pieces:");

                foreach (var piece in blackPieces)
                {
                    piece.Draw(renderer);
                }

                Thread.Sleep(1000);

                renderer.Clear();

                whitePieces.RemoveAt(0);
                blackPieces.RemoveAt(0);
            }
        }
    }
}
