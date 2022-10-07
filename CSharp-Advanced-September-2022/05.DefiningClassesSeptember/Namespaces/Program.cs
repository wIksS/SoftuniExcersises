using System;
using C = CarManufacturer.Car;

namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C car = new C();


            Console.WriteLine(car.WhoAmI());
        }
    }
}


