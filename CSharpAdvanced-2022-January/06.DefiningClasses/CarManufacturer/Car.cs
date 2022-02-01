using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        string make;
        string model;
        int year;
        double fuelQuantity;
        double fuelConsumption;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, int fuelQuantity, int fuelConsumption) 
            : this(make, model, year)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }


        public Car(string make, string model, int year, int fuelQuantity, int fuelConsumption, Engine engine, Tire[] tires)
    : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        public string Make { get { return this.make; } set { this.make = value; } }
        public string Model { get { return this.model; } set { this.model = value; } }
        public int Year { get { return this.year; } set { this.year = value; } }
        public double FuelQuantity { get { return this.fuelQuantity; } set { this.fuelQuantity = value; } }
        public double FuelConsumption { get { return this.fuelConsumption; } set { this.fuelConsumption = value; } }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            if (fuelQuantity - distance * fuelConsumption > 0)
            {
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make} Model: { this.Model} Year: { this.Year} Fuel: { this.FuelQuantity:F2}";
        }
    }
}
