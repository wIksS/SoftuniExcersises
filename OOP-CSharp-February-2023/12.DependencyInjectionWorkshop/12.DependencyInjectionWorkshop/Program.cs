
using _12.DependencyInjectionWorkshop;
using ChessDependencyInversion;
using ChessDependencyInversion.Renderers;
using IServiceProvider = SoftuniIoC.Contracts.IServiceProvider;

// IoC - Inversion of Control container

IServiceProvider serviceProvider = ServiceConfigurator.ConfigureServices();

ChessEngine chess = serviceProvider.GetService<ChessEngine>();

Scoreboard scoreboard = serviceProvider.GetService<Scoreboard>();

scoreboard.DrawScore();

//chess.Start();