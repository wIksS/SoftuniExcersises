
using CustomDIUsage;
using MicrosoftDependecyInjection.DI;
using IServiceProvider = CustomDI.IServiceProvider;

IServiceProvider serviceProvider = DIContainer.BuildServiceProvider();


Engine engine = serviceProvider.GetService<Engine>();

engine.Something();


interface IRandomGenerator
{
    public int GetRandom();
}

class SmallRandomGenerator : IRandomGenerator
{
    public SmallRandomGenerator(DateTime dateToday)
    {
        Console.WriteLine("Small random generator created");
    }

    public int GetRandom()
    {
        return new Random().Next(0, 10);
    }
}