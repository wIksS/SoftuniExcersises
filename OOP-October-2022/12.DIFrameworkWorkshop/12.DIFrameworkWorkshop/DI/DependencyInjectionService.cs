using _12.DIFrameworkWorkshop.Common;
using _12.DIFrameworkWorkshop.Drawers;
using _12.DIFrameworkWorkshop.Drawers.Contracts;
using _12.DIFrameworkWorkshop.Renderers;
using DIFramework;
using DIFramework.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using IServiceProvider = DIFramework.Contracts.IServiceProvider;

namespace _12.DIFrameworkWorkshop.DI
{
    internal class DependencyInjectionService
    {
        public static IServiceProvider ConfigureServices()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            //custom code
            serviceCollection.AddTransient<IShapeDrawer, AdvancedShapeDrawer>();
            serviceCollection.AddTransient<Engine, Engine>();
            serviceCollection.AddTransient<IRenderer, ConsoleRenderer>(s =>
            {
                return new ConsoleRenderer();
            });

            serviceCollection.AddTransient<IDateLogger, DateLogger>((s) =>
            {
                return new DateLogger(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            });
            serviceCollection.AddTransient<ILogger, Logger>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
