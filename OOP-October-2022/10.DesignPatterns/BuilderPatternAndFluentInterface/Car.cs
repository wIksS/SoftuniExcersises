using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternAndFluentInterface
{
    internal class Car
    {
        public Car BuildEngine()
        {
            Console.WriteLine("Building engine..");
            Engine = new Engine();

            return this;
        }

        public Car BuildNavigation()
        {
            Console.WriteLine("Building navigation..");
            Navigation = true;

            return this;
        }

        public Car BuildHeatedSeats()
        {
            Console.WriteLine("Building heated seats..");
            HeatedSeats = true;

            return this;
        }

        public bool Navigation { get; set; }
        public bool HeatedSeats { get; set; }

        public Engine Engine { get; set; }
    }
}
