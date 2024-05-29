using CustomDI;
using CustomDIUsage;
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
            IServiceCollection collection = new ServiceCollection();

            collection.AddTransient<IRandomGenerator, SmallRandomGenerator>();
            collection.AddTransient<Engine, Engine>();

            collection.AddTransient<DateTime, DateTime>((sp) =>
            {
                return DateTime.Now.AddDays(365);
            });

            return collection.BuildServiceProvider();
        }
    }
}
