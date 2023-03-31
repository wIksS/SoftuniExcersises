using _12.DependencyInjectionWorkshop.Contracts;
using _12.DependencyInjectionWorkshop.Loggers;
using ChessDependencyInversion;
using ChessDependencyInversion.Renderers;
using SoftuniIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IServiceProvider = SoftuniIoC.Contracts.IServiceProvider;

namespace _12.DependencyInjectionWorkshop
{
    public class ServiceConfigurator
    {
        public static IServiceProvider ConfigureServices()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IRenderer, ConsoleRenderer>();
            serviceCollection.AddTransient<ChessEngine, ChessEngine>();
            serviceCollection.AddTransient<Scoreboard, Scoreboard>();
            serviceCollection.AddTransient<ILogger, ConsoleLogger>(serviceProvider =>
            {
                return new ConsoleLogger(DateTime.Now);
            });
            serviceCollection.AddTransient<IDateProvider, PastDateProvider>();


            return serviceCollection.BuildServiceProvider();
        }
    }
}
