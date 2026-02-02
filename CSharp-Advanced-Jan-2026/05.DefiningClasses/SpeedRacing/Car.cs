using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
//•	string Model
//•	double FuelAmount
//•	double FuelConsumptionPerKilometer
//•	double Travelled distance

    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * FuelConsumptionPerKilometer;
            if (fuelNeeded > FuelAmount)
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
            else
            {
                TravelledDistance += distance;
                FuelAmount -= fuelNeeded;
            }
        }
    }
}
