using DependencyInjectionWorkshop.Contracts;
using DependencyInjectionWorkshop.DI.Containers;
using DependencyInjectionWorkshop.Drawers;
using DependencyInjectionWorkshop.Loggers;
using DependencyInjectionWorkshop.Movers;
using DependencyInjectionWorkshop.Readers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop
{
    public class SnakeGameContainer : AbstractContainer
    {
        public override void ConfigureServices()
        {
            CreateMapping<ILogger, FileLogger>(()=> new FileLogger("../../../logs.txt"));
            CreateMapping<IReader, ConsoleReader>();
            CreateMapping<IDrawer, ConsoleDrawer>();
            CreateMapping<IMover, FastMover>();
        }
    }
}
