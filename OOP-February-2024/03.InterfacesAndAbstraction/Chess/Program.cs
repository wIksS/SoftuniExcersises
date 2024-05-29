



using Chess;
using Chess.Drawers;

IDrawer drawer = new FileDrawer();

ChessGame chess = new ChessGame(drawer);

chess.Start();