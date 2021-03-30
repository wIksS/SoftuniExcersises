using Microsoft.Extensions.DependencyInjection;
using MicrosoftDepencyInjection.Contracts;
using MicrosoftDepencyInjection.Loggers;
using MicrosoftDepencyInjection.MicrosoftDepencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDepencyInjection
{
    class ServiceConfigurator
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<ILogger, FileLogger>(f => new FileLogger("../../../logstest.txt"));
            
            //serviceCollection.AddTransient<ILogger, ConsoleLogger>();

            serviceCollection.AddTransient<Engine, Engine>();

            serviceCollection.AddTransient<IGameMovement, GameMovement>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
