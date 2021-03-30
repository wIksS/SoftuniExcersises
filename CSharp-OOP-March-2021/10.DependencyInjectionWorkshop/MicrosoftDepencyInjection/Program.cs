using Microsoft.Extensions.DependencyInjection;
using System;

namespace MicrosoftDepencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = ServiceConfigurator.ConfigureServices();

            Engine engine = serviceProvider.GetRequiredService<Engine>();

            engine.Start();
            engine.End();
        }
    }
}
