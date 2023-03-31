using _12.DependencyInjectionWorkshop;
using _12.DependencyInjectionWorkshop.Contracts;
using ChessDependencyInversion;
using ChessDependencyInversion.Renderers;
using SoftuniIoC.Contracts;
using SoftuniIoC.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniIoC
{
    public class ServiceConfigurator
    {
        public static Contracts.IServiceProvider ConfigureServices()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection
                .AddTransient<IPromotionService, PromotionService>()
                .AddTransient<IRenderer, ConsoleRenderer>()   
                .AddTransient<IDateProvider, DateProvider>();

            serviceCollection.AddTransient<DateTime, DateTime>(serviceProvider =>
            {
                Console.WriteLine("I am in the function!!!!");
                return DateTime.Now;
            });

            return serviceCollection.BuildServiceProvider();
        }
    }
}
