using _12.DependencyInjectionWorkshop.Loggers;
using _12.DependencyInjectionWorkshop.Renderers;
using SoftuniIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop.DI
{
    internal class DI
    {
        public static ServiceProvider BuildServices()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IRenderer, ConsoleRenderer>(sp =>
            {
                return new ConsoleRenderer(new ConsoleLogger());
            });

            serviceCollection.AddSingleton<ILogger, ConsoleLogger>();
            serviceCollection.AddSingleton<Engine, Engine>();
            serviceCollection.AddTransient<Shape, Shape>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
