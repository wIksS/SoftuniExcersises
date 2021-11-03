using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfCars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "1", "2", "3" };
            int[] numbers = arr.Select(int.Parse).ToArray();

            List<Car> cars = new List<Car>()
            {
                new Car(){Model="BMW"},
                new Car(){Model="Audi"},
                new Car(){Model="Brakma"}
            };

            cars = cars.OrderBy(c => c.Price).ThenBy(c => c.Manufacturer).ToList();

            List<decimal> models = cars.Select(c => c.Price).ToList();

            Console.WriteLine(string.Join(" ", models));
        }

        static int Parse(string x)
        {
            return int.Parse(x);
        }

        static string GetCarModel(Car car)
        {
            return car.Model;
        }
    }

    class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
    }
}
