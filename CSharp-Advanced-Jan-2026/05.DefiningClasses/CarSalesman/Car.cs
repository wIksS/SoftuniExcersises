using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    internal class Car
    {
        public Car(string model, Engine engine, int? weight = 0, string color = "")
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int? Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{Model}:");
            result.AppendLine($"{Engine}");

            if (Weight != null)
            {
                result.AppendLine($"  Weight: {Weight}");
            }
            else
            {
                result.AppendLine($"  Weight: n/a");
            }
            if (Color != null)
            {
                result.AppendLine($"  Color: {Color}");
            }
            else
            {
                result.AppendLine($"  Color: n/a");
            }
            return result.ToString().Trim();
        }
    }
}
