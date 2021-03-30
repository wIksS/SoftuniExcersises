using Autofac;
using DependencyInjectionWorkshop.Contracts;
using DependencyInjectionWorkshop.DI.Containers;
using DependencyInjectionWorkshop.Drawers;
using DependencyInjectionWorkshop.GameObjects;
using DependencyInjectionWorkshop.Loggers;
using DependencyInjectionWorkshop.Movers;
using DependencyInjectionWorkshop.Readers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop
{
    class InjectorSingleton
    {
        private static ILifetimeScope instance;


        public static ILifetimeScope Instance
        {
            get
            {
                if (instance == null)
                {
                    var builder = new ContainerBuilder();
                    builder.RegisterType<ConsoleLogger>().As<ILogger>();
                    builder.RegisterType<ConsoleReader>().As<IReader>();
                    builder.RegisterType<ConsoleDrawer>().As<IDrawer>();
                    builder.RegisterType<FastMover>().As<IMover>();
                    builder.RegisterType<Engine>().As<Engine>();
                    builder.RegisterType<Ball>().As<Ball>();
                    builder.RegisterType<Enemy>().As<Enemy>();

                    instance = builder.Build().BeginLifetimeScope();
                }

                return instance;
            }
        }
        //public static Injector Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            SnakeGameContainer container = new SnakeGameContainer();
        //            container.ConfigureServices();
        //            instance = new Injector(container);
        //        }

        //        return instance;
        //    }
        //}
    }
}
