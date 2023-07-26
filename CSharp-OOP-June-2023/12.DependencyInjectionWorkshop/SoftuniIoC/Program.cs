

using _12.DependencyInjectionWorkshop.Loggers;
using _12.DependencyInjectionWorkshop.Renderers;
using SoftuniIoC;
using SoftuniIoC.Example;

ServiceCollection serviceCollection = new ServiceCollection();

serviceCollection.AddTransient<Engine, Engine>();
serviceCollection.AddSingleton<ILogger, ConsoleLogger>();
serviceCollection.AddTransient<IRenderer, ConsoleRenderer>();
serviceCollection.AddTransient<int, int>(sp => 60);
serviceCollection.AddTransient<DateTime, DateTime>(serviceProvider =>
{
    return DateTime.Now;
});

ServiceProvider provider = serviceCollection.BuildServiceProvider();

//Engine engine = provider.GetService<Engine>();

ILogger logger = provider.GetService<ILogger>();
logger = provider.GetService<ILogger>();
logger = provider.GetService<ILogger>();
logger = provider.GetService<ILogger>();
logger = provider.GetService<ILogger>();
logger = provider.GetService<ILogger>();

