

using DepencyInjectionConstructor;
using DepencyInjectionConstructor.IO;
using DepencyInjectionConstructor.IO.Interfaces;
using TextWriter = DepencyInjectionConstructor.IO.FileWriter;

IWriter writer = new ConsoleWriter();

IReader reader = new ConsoleReader();

ChessGamePropertyInversion game = new ChessGamePropertyInversion();

game.Writer = writer;
game.Reader = reader;

game.Run();

game.Writer = new TextWriter();

game.Run();

game.Writer = writer;

game.Run();

//ChessGame game = new ChessGame(writer, reader);

//game.Run();