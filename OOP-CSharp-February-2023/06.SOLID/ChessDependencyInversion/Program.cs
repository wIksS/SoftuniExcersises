
using ChessDependencyInversion;
using ChessDependencyInversion.Renderers;

ChessEngine chess = new ChessEngine(new WebRenderer());

chess.Start();