using System;

namespace BuilderPatternAndFluentInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.BuildNavigation()
                .BuildEngine()
                .BuildNavigation()
                .BuildEngine()
                .BuildEngine()
                .BuildEngine();



            Console.WriteLine(car);
        }
    }
}
