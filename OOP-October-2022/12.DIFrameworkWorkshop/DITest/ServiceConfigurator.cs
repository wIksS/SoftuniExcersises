using _12.DIFrameworkWorkshop.Renderers;
using DIFramework;
using DIFramework.Contracts;
using System;
using IServiceProvider = DIFramework.Contracts.IServiceProvider;

namespace DITest
{
    internal class ServiceConfigurator
    {
        public static IServiceProvider ConfigureServices()
        {
            IServiceCollection collection = new ServiceCollection();

            collection.AddTransient<Engine, Engine>();
            collection.AddTransient<IRenderer, ConsoleRenderer>();
            collection.AddTransient<DateTime, DateTime>(serviceProvider =>
            {
                Console.WriteLine("In Factory");
                return DateTime.Now;
            });

            return collection.BuildServiceProvider();
        }
    }
}
