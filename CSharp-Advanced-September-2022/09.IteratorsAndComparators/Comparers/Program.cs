using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Comparers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bmw = new Car(150, "BMW");
            var audi = new Car(300, "AUDI");
            var mercedes = new Car(100, "MERCEDES");
            //SortedSet<Car> cars = new SortedSet<Car>(new CarComparer());
            List<Car> cars = new List<Car>();

            cars.Add(bmw);
            cars.Add(audi);
            cars.Add(mercedes);

            cars.Sort(new CarComparer());

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} - {car.HorsePower}");
            }
        }
    }

    class Car
    {
        public Car(int horsePower, string model)
        {
            HorsePower = horsePower;
            Model = model;
        }

        public int HorsePower { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"{Model} - {HorsePower}";
        }
    }

    class CarComparer : IComparer<Car>
    {
        public int Compare([AllowNull] Car x, [AllowNull] Car y)
        {
            return y.HorsePower.CompareTo(x.HorsePower);
        }
    }
}
