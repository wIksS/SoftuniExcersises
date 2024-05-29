using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftDependecyInjection.DI
{
    public class DIContainer
    {
        public static IServiceProvider BuildServiceProvider()
        {
            ServiceCollection collection = new ServiceCollection();

            collection.AddTransient<IRandomGenerator, SmallRandomGenerator>();
            collection.AddTransient(typeof(DateTime),(IServiceProvider sp) =>
            {
                return DateTime.Now;
            });

            collection.AddTransient<StringBuilder>((sp) =>
            {
                var sb = new StringBuilder();
                sb.AppendLine("WOW!");

                return sb;
            });

            //collection.AddScoped<IRandomGenerator, SmallRandomGenerator>();
            //collection.AddSingleton<IRandomGenerator, SmallRandomGenerator>();

            return collection.BuildServiceProvider();
        }
    }
}
