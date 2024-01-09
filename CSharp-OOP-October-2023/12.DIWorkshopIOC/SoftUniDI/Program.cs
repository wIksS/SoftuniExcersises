
using Renderers.Renderers;
using SoftUniDI;
using SoftUniDI.Loggers;

ServiceCollection collection = new ServiceCollection();

collection.AddSingleton<ILogger, ConsoleLogger>();
collection.AddSingleton<DB, DB>();
collection.AddSingleton(typeof(IRenderer), typeof(ConsoleRenderer));
collection.AddSingleton<DateTime, DateTime>((SoftUniDI.IServiceProvider sp) =>
{
    return new DateTime(1997, 11, 10);
});

SoftUniDI.IServiceProvider provider = collection.BuildServiceProvider();


ILogger logger = provider.GetRequiredService<ILogger>();

logger.Log("Hello from logger");


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(provider.GetRequiredService<DB>().Guid);
}

class DB
{
    public Guid Guid { get; set; }

    public DB()
    {
        Guid = Guid.NewGuid();
    }
}


