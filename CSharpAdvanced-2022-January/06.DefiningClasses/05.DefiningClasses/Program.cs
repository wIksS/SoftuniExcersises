using System;

namespace _05.DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime timeNow = new DateTime(1997, 5, 23);
            Car bmw = new Car()
            {
                Name = "3",
                Company = "BMW",
                Category = "Cars",
                Price = 3000
            };
            bmw.Drive(23);
            bmw.Drive(33);

            Car audi = new Car()
            {
                Name = "a3",
                Company = "Audi",
                Category = "Cars",
                Price = 3500
            };
            audi.Drive(15);
            audi.Drive(45);

            Console.WriteLine($"Car: {bmw.Name}, {bmw.Price}, {bmw.Company} - Mileage {bmw.Mileage}");

            Console.WriteLine($"Car: {audi.Name}, {audi.Price}, {audi.Company} - Mileage {audi.Mileage}");
        }
    }
}
