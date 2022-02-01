using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Gogi";
            person.LastName = "Gogov";
            person.FullName = "Bobi Bobov";
            Console.WriteLine(person.FullName);
            return;
            Car car = new Car();
            car.Mileage = 5;
            Console.WriteLine($"Mileage: {car.Mileage}");

            car.Mileage = -5;
            Console.WriteLine($"Mileage: {car.Mileage}");

            car.Mileage += 15;
            Console.WriteLine($"Mileage: {car.Mileage}");

            car.Mileage = -5;
            Console.WriteLine($"Mileage: {car.Mileage}");
        }
    }
}
