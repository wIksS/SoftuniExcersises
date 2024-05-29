



using Chess;
using Chess.Drawers;

IDrawer drawer = new ConsoleDrawer();

ChessGame chess = new ChessGame(drawer);

chess.Start();