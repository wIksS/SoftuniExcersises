
using Microsoft.Extensions.DependencyInjection;
using MicrosoftDependecyInjection.DI;
using System.Text;

var serviceProvider = DIContainer.BuildServiceProvider();

var random = serviceProvider.GetService<IRandomGenerator>();


interface IRandomGenerator
{
    public int GetRandom();
}

class SmallRandomGenerator : IRandomGenerator
{
    public SmallRandomGenerator(DateTime dateToday, StringBuilder sb)
    {
        Console.WriteLine("Small random generator created");

        Console.WriteLine(sb);
    }
    public int GetRandom()
    {
        return new Random().Next(0, 10);
    }
}