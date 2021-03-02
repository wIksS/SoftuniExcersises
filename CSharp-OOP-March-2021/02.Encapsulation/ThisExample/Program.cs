using System;
using Encapsulation;
namespace ThisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "golfa";
            car.Drive(5);
            car.Drive(5);

            Car newCar = car.InitCar();
        }
        class User
        {
            public static void Drive(Car car)
            {
                car.Miles += 50;
            }
        }

        class Car
        {
            private int x;
            public int Miles { get; set; }
            public string Name { get; set; }

            public void Drive(int Miles)
            {
                User.Drive(this);
                this.Miles += Miles;
            }

            public Car InitCar()
            {
                Miles = 0;
                return this;
            }
        }


    }
}
