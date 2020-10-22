using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Manufacturer == manufacturer && 
                    data[i].Model == model)
                {
                    data.RemoveAt(i);
                    return true;
                }
            }

            return false;
            Car carToRemove = data.FirstOrDefault(c =>
                        c.Manufacturer == manufacturer
                        && c.Model == model);
            if (carToRemove != null)
            {
                data.Remove(carToRemove);
                return true;
            }

            return false;
        }

        public Car GetLatestCar()
        {
            Car newestCar = data.OrderByDescending(c => c.Year)
                .FirstOrDefault();
            return newestCar;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(c =>
            c.Manufacturer == manufacturer
            && c.Model == model);

            return car;
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in data)
            {
                result.AppendLine(car.ToString());
            }

            return result.ToString();
        }
    }
}
