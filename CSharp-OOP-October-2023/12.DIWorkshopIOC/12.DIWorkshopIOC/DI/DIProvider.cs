using _12.DIWorkshopIOC.Loggers;
using Renderers;
using Renderers.Renderers;
using SoftUniDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServiceProvider = SoftUniDI.IServiceProvider;

namespace _12.DIWorkshopIOC.DI
{
    public class DIProvider
    {
        public static IServiceProvider GetServiceProvider()
        {
            ServiceCollection collection = new ServiceCollection();

            collection.AddSingleton<IRenderer, ConsoleRenderer>();
            collection.AddSingleton<ILogger, ConsoleLogger>();
            collection.AddSingleton<Canvas, Canvas>();
            collection.AddSingleton<StringBuilder, StringBuilder>((IServiceProvider provider) =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("CustomlyCreated!!!");

                return sb;
            });

            return collection.BuildServiceProvider();
        }
    }
}
