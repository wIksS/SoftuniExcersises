using CustomDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServiceProvider = CustomDI.IServiceProvider;

namespace MicrosoftDependecyInjection.DI
{
    public class DIContainer
    {
        public static IServiceProvider BuildServiceProvider()
        {
            ServiceCollection collection = new ServiceCollection();

            collection.AddTransient<IRandomGenerator, SmallRandomGenerator>();
            collection.AddTransient<ILogger, PurpleConsoleLogger>();
            collection.AddTransient<Engine, Engine>();
            collection.AddTransient<DateTime, DateTime>(sp =>
            {
                return DateTime.Now;
            });

            return collection.BuildServiceProvider();
        }
    }
}
